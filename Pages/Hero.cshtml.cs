using DreamBuild.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.CompilerServices;

namespace DreamBuild.Pages
{
    public class HeroModel : PageModel
    {
        public HeroPage Hero { get; set; }

        public async Task OnGetAsync(int id)
        {
            Hero = await Utils.GetHeroById(id);
        }
    }
}
