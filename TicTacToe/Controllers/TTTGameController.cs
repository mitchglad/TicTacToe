using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Models;
using TicTacToe.Repositories;

namespace TicTacToe.Controllers
{
    [Route("api/tttgame")]
    [ApiController]
    public class TttGameController : Controller
    {
        
        private static GameRepository repo = new GameRepository();
        //public TttGameController(IRepository<Game> gameRepository)
        //{
            
        //}

        // GET api/tttcontroler
        [HttpGet]
        public IActionResult Get()
        {
            return Json(repo.ReturnAllGameID());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            return Json(repo.GetById(id));
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(400)]
        public ActionResult<string>Post(NewGameModel value)
        {
            Player player1 = new Player(value.X, GameSign.X);
            Player player2 = new Player(value.O, GameSign.O);
            Game game = new Game(player1, player2, value.GameId);
            repo.Add(game);
            return Ok();
        }

        //[HttpPost]
        //[ProducesResponseType(400)]
        //public async Task<ActionResult<Pet>> CreateAsync(Pet pet)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    await _repository.AddPetAsync(pet);
        //    return CreatedAtAction(nameof(GetByIdAsync),
        //        new { id = pet.Id }, pet);
        //}
    }
}
