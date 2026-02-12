using Microsoft.AspNetCore.Mvc;
using GameTournamentAPI.Data;
using GameTournamentAPI.Model;

namespace GameTournamentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TournamentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TournamentController(AppDbContext context)
        {
            _context = context;
        }

        // TEST GET
        [HttpGet]
        public IActionResult GetTournaments()
        {
            var tournaments = _context.Tournaments.ToList();
            return Ok(tournaments);
        }

        [HttpPost]
        public IActionResult CreateTournament(Tournament tournament)
        {
            _context.Tournaments.Add(tournament);
            _context.SaveChanges();

            return Ok(tournament);
        }
    }
}