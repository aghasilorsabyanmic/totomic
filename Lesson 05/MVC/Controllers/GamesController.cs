using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC.Controllers
{
    public class GamesController : ApiController
    {
        // GET: api/Games
        public IEnumerable<Game> Get()
        {
            return ModelFactory.GetGames().Where(g => !g.IsDeleted);
        }

        // GET: api/Games/5
        public IHttpActionResult Get(Guid id)
        {
            var game = ModelFactory.GetGames().FirstOrDefault(g => g.Id == id && !g.IsDeleted);

            if(game == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(game);
            }
        }

        // POST: api/Games
        public void Post([FromBody]Game game)
        {
            var games = ModelFactory.GetGames().ToList();

            games.Add(game);
        }

        // PUT: api/Games/5
        public void Put(Guid id, [FromBody]Game game)
        {
            var games = ModelFactory.GetGames().ToList();
            var tmpGame = games.FirstOrDefault(g => g.Id == id && !g.IsDeleted);

            if(tmpGame != null)
            {
                tmpGame = game;
            }
        }

        // DELETE: api/Games/5
        public void Delete(Guid id)
        {
            var game = ModelFactory.GetGames().FirstOrDefault(g => g.Id == id && !g.IsDeleted);

            if (game != null)
            {
                game.IsDeleted = true;
            }
        }
    }
}
