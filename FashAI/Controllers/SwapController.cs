using FashAI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FashAI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SwapController : ControllerBase
    {
        private readonly List<Wardrobe> publicWardrobes = new List<Wardrobe>();

        [HttpPost("add-to-swap")]
        public IActionResult AddToSwap(Wardrobe wardrobe)
        {
            publicWardrobes.Add(wardrobe);
            return Ok("Item added to swap list.");
        }

        [HttpGet("available-swaps")]
        public IActionResult GetAvailableSwaps()
        {
            return Ok(publicWardrobes);
        }
    }
}
