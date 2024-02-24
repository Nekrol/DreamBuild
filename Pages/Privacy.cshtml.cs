using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace DreamBuild.Pages
{
    public class PrivacyModel : PageModel
    {
        public bool nameEdit;
        public string Name { get; set; }
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
            Name = DataContest.Username;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(string name)
        {
            if(String.IsNullOrEmpty(name))
            {
                nameEdit = true;
            }
            else
            {
                nameEdit = false;
                DataContest.Username = name;
                Name = DataContest.Username;
            }
            return Page();
        }
    }
}