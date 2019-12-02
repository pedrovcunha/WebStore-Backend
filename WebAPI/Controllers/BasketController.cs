using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using WebStore.Domain.DTOs;
using WebStore.Domain.Entities;
using WebStore.Domain.Interfaces;

namespace WebStore.WebAPI.Controllers
{
    [ApiController]
    [Route("api/baskets")]
    [Produces("application/json")]
    public class BasketController : RootController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BasketController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        [HttpHead]
        public ActionResult<IEnumerable<BasketDto>> GetBaskets()
        {
            var basketsFromRepo = _unitOfWork.Basket.GetAll().ToList();

            Request.HttpContext.Response.Headers.Add("X-Total-Count", basketsFromRepo.Count().ToString());
            return Ok(_mapper.Map<List<BasketDto>>(basketsFromRepo));
        }

        [HttpGet("{basketId}", Name = "GetBasket")]
        public IActionResult GetBasket([FromRoute]Guid basketId)
        {
            var basketsFromRepo = _unitOfWork.Basket.GetById(basketId);
            if (basketsFromRepo == null)
                return NotFound();
            
            // Adds the basket total in the header.
            Request.HttpContext.Response.Headers.Add("X-Basket-Total", basketsFromRepo.Products.Sum(x => x.UnitPrice).ToString());
            return Ok(_mapper.Map<BasketDetailsDto>(basketsFromRepo));
        }

        [HttpGet("({ids})", Name ="GetProductsByBasket")]
        public IActionResult GetProductsByBasket(
            [FromRoute]
            [ModelBinder(BinderType = typeof(ArrayModelBinder<>))] IEnumerable<Guid> ids)
        {
            if (ids == null)
            {
                return BadRequest();
            }

            var idsArray = ids.ToArray();
            Expression<Func<Product, bool>>[] productExpression = { x => ids.Contains(x.Id)};

            var productEntities = _unitOfWork.Product.GetAll(productExpression);

            if (ids.Count() != productEntities.Count())
            {
                return NotFound();
            }

            var productsToReturn = _mapper.Map<IEnumerable<ProductDto>>(productEntities);

            return Ok(productsToReturn);
        }

        [HttpPost]
        public async Task<ActionResult<Basket>> CreateBasket(BasketForCreationDto basket)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var basketEntity = _mapper.Map<Basket>(basket);

            await _unitOfWork.Basket.Add(basketEntity);

            return CreatedAtRoute("GetBasket",
                new { basketId = basketEntity.Id },
                basketEntity);
        }

        [HttpPost]
        [Route("{basketId}/products")]
        public async Task<ActionResult<Basket>> AddProductsIntoBasket([FromRoute] Guid basketId, [FromBody]IEnumerable<ProductForCreationDto> productCollection)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            foreach (var product in productCollection)
            {
                product.BasketId = basketId;
            }
            
            var listofProducts = _mapper.Map<List<Product>>(productCollection);

            _unitOfWork.Product.AddRange(listofProducts);

            var productsCollectionToReturn = _mapper.Map<IEnumerable<ProductDto>>(listofProducts);
            var idsAsString = string.Join(",", productsCollectionToReturn.Select(a => a.Id));
            return CreatedAtRoute("GetProductsByBasket",
                new { ids = idsAsString },
                productsCollectionToReturn);
        }


        [HttpOptions]
        public IActionResult GetBasketOptions()
        {
            Response.Headers.Add("Allow", "GET,OPTIONS,POST");
            return Ok();
        }

        [HttpDelete("{basketId}")]
        public async Task<ActionResult> DeleteBasket(Guid basketId)
        {
            var basketFromRepo = _unitOfWork.Basket.GetById(basketId);

            if (basketFromRepo == null)
            {
                return NotFound();
            }

            var productsToUpdate = _unitOfWork.Product.GetAll(new Expression<Func<Product, bool>>[]
                {x => x.BasketId == basketId});

            foreach (var product in productsToUpdate)
            {
                product.BasketId = null;
                _unitOfWork.Product.Update(product);
            }
            await _unitOfWork.Basket.Remove(basketFromRepo);
            
            return NoContent();
        }
    }
}
