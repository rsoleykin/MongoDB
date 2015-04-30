using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMongoDBApplication.Controllers
{
    using System.Threading.Tasks;
    using MongoDBData.Entities;
    using MongoDBData.Enumerables;
    using MongoDBData.Service;

    public class HomeController : Controller
    {
        

        public async Task<ActionResult> Index()
        {
            var _teamService = new TeamsService();
            var team = new Team()
            {
                Conference = Conferencetype.Eastern,
                ConferencePosition = 2,
                GamesLost = 30,
                GamesWon = 43,
                Name = "Chicago Bulls"
            };
            _teamService.AddTeam(team);


            ///var res = _teamService.GetTemaById(team.Id.ToString());

            return View();
        }

    }
}
