using DreamBuild.Models;
using System.Text.Json;

namespace DreamBuild
{
    public static class Utils
    {
        public async static Task<HeroPage> GetHeroById(int id)
        {
            var hero = new HeroPage();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("https://www.dota2.com/datafeed/herodata?language=russian&hero_id=" + id.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    Root myDeserializedClass = JsonSerializer.Deserialize<Root>(json);
                    if (myDeserializedClass.result.data.heroes.Count > 0)
                    {

                        hero.Name = myDeserializedClass.result.data.heroes[0].name_loc;
                        hero.Description = myDeserializedClass.result.data.heroes[0].bio_loc;
                        hero.Abilities = myDeserializedClass.result.data.heroes[0].abilities;
                    }
                }
            }
            return hero;
        }
    }
}
