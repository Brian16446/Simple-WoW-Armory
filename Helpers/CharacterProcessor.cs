using SimpleWoWArmory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleWoWArmory.Helpers
{
    public class CharacterProcessor
    {
        public static async Task<CharacterModel> LoadCharacter(string characterName, string characterRealm)
        {

            //string characterName = "Kalazab";
            string url = $"https://EU.api.blizzard.com/wow/character/{characterRealm}/{characterName}?access_token=USnvIaiMyFGLgp28TAQ1eMgJHODEhwxB2v";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CharacterModel character = await response.Content.ReadAsAsync<CharacterModel>();

                    return character;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<CharacterStatsModel> LoadCharacterStats(string characterName, string characterRealm)
        {
            string url = $"https://eu.api.blizzard.com/profile/wow/character/{characterRealm}/{characterName}/statistics?namespace=profile-eu&locale=en_gb&access_token=USnvIaiMyFGLgp28TAQ1eMgJHODEhwxB2v";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CharacterStatsModel character = await response.Content.ReadAsAsync<CharacterStatsModel>();

                    return character;
                }
                else
                {
                    throw new Exception(url);
                }
            }
        }
    }
}
