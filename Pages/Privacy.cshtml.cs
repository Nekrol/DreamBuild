using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace DreamBuild.Pages
{
    public class PrivacyModel : PageModel
    {
        public bool nameEdit;
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostEditName()
        {
            if(nameEdit)
            {
                nameEdit = false;
                return RedirectToPage();
            }
            else
            {
                nameEdit = true;
                return RedirectToPage();
            }
        }
    }
}