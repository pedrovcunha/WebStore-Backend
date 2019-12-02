using Microsoft.AspNetCore.Mvc;

namespace WebStore.WebAPI.Controllers
{
    [ApiController]
    public abstract class RootController : ControllerBase
    {

        //[HttpGet(Name = "GetRoot")]
        //public IActionResult GetRoot()
        //{  
        //    // create links for root
        //    var links = new List<LinkDto>();

        //    links.Add(
        //        new LinkDto(Url.Link("GetRoot", new { }),
        //            "self",
        //            "GET"));

        //    links.Add(
        //        new LinkDto(Url.Link("GetBasket", new { }),
        //            "baskets",
        //            "GET"));

        //    links.Add(
        //        new LinkDto(Url.Link("CreateBasket", new { }),
        //            "create_basket",
        //            "POST"));

        //    return Ok(links);

        //}
    }
}
