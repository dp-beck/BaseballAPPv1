using BaseballApp.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace BaseballAPP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private List<PlayerModel> Players = [];

        [HttpGet("GetNamePlayer")]
        public string GetNameofPlayer()
        {
            return "Alex";
        }

        [HttpGet("GetListPlayers")]
        public List<PlayerModel> GetListOfPlayers()
        {
            return Players;
        }


        [HttpPost]
        public bool CreateNewPlayer(string name, string position)
        {
            PlayerModel player = new PlayerModel(name, position);

            if (player is null)
            {
                return false;
            }

            Players.Add(player);
            return true;
        }
    }
}
