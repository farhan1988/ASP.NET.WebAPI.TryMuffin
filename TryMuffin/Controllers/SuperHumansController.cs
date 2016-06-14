using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TryMuffin.Models;

namespace TryMuffin.Controllers
{
    public class SuperHumansController : ApiController
    {
        List<MetaHuman> heroes = new List<MetaHuman>();

        /// <summary>
        /// Deafault constructor
        /// </summary>
        public SuperHumansController() { }

        /// <summary>
        /// Constructor with parameter
        /// </summary>
        /// <param name="heroes"></param>
        public SuperHumansController(List<MetaHuman> heroes)
        {
            this.heroes = heroes;
        }

        /// <summary>
        /// Method to get all super humans A.K.A Heroes
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MetaHuman> GetAllHeroes()
        {
            return heroes;
        }

        /// <summary>
        /// Method to get all super humans A.K.A Heroes ASYNCHORNOUSLY
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<MetaHuman>>  GetAllHeroesAsync()
        {
            return await Task.FromResult(GetAllHeroes());
        }
    }
}
