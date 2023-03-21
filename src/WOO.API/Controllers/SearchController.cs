namespace WOO.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WOO.Application.Service;
    using WOO.Domain.Model;

    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService eventService;

        public PlayerController(IPlayerService eventService)
        {
            this.eventService = eventService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var events = this.eventService.GetAll();

            return Ok(events);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var e = this.eventService.GetPlayerById(id);

            if (e == null)
            {
                return NotFound();
            }

            return Ok(e);
        }

        [HttpPost]
        public IActionResult SearchPlayers([FromBody] string searchQuery)
        {
            IEnumerable<Player> events = new List<Player>();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                events = this.eventService.SearchPlayers(searchQuery);
            }

            return new JsonResult(events);
        }
    }
}