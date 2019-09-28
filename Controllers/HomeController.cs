using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleWoWArmory.Helpers;
using SimpleWoWArmory.Models;

namespace SimpleWoWArmory.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ViewCharacter(string characterName, string characterRealm)
        {
            string cName = characterName.ToLower();
            string cRealm = characterRealm.ToLower();

            ApiHelper.InitialiseClient();
            CharacterModel character = await CharacterProcessor.LoadCharacter(cName, cRealm);
            CharacterStatsModel characterStats = await CharacterProcessor.LoadCharacterStats(cName, cRealm);

            CharacterDataModel characterData = new CharacterDataModel();
            characterData.CharacterData = character;
            characterData.CharacterStatsData = characterStats;


            
            return View(characterData);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
