using FashAI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FashAI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WardrobeController : ControllerBase
    {
        private readonly WardrobeService _wardrobeService;
        
        public WardrobeController(WardrobeService wardrobeService)
        {
            _wardrobeService = wardrobeService;
        }

        [HttpGet("categorize")]
        public IActionResult GetWardrobeByCategory([FromQuery] string season, [FromQuery] string gender, [FromQuery] string occasion, [FromQuery] string clothingType)
        {
            var items = _wardrobeService.GetWardrobeByCategory(season, gender, occasion, clothingType);
            if (items == null || !items.Any())
                return NotFound("No matching items Found.");

            return Ok(items);
        }
    }
}
