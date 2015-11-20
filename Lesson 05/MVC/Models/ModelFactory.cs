using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ModelFactory
    {
        public static IEnumerable<Game> GetGames()
        {
            var games = new Game[]
            {
                new Game
                {
                    Id = new Guid("4B45A297-95C0-4C2D-A910-8BAA43B734BF"),
                    Name = "Game 1",
                    Created = DateTime.Now.AddHours(-1)
                },

                new Game
                {
                    Id = new Guid("4999E071-3A5E-48C8-805B-EDC0209E67AD"),
                    Name = "Game 2",
                    Created = DateTime.Now.AddHours(-2)
                },

                new Game
                {
                    Id = new Guid("1E58EF6F-04F3-41B3-912C-FA4F8A22DC55"),
                    Name = "Game 3",
                    Created = DateTime.Now.AddHours(-3)
                }
            };

            return games;
        }
    }
}