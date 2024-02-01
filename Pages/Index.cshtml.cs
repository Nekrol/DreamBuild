using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DreamBuild.DAL;

namespace DreamBuild.Pages
{
    public class IndexModel : PageModel
    {
        private DBConnection _dBConnection;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _dBConnection = new DBConnection();
        }

        public void OnGet()
        {
            _dBConnection.CreateConnection();
        }
    }
}