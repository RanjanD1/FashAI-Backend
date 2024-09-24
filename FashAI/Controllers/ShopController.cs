using Microsoft.AspNetCore.Mvc;

namespace FashAI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShopController : ControllerBase
    {
        [HttpGet("shop-item")]
        public IActionResult GetShopLink([FromQuery] string itemName)
        {
            //Placeholder: In the future, integrate with APIs from shopping platforms
            string shopLink = $"https://example.com/shop?item={itemName}";
            return Ok(new { item = itemName, link = shopLink });
        }
    }
}
