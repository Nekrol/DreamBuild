using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DreamBuild.DAL;
using DreamBuild.Models;
using Microsoft.Data.SqlClient;

namespace DreamBuild.Pages
{
    public class IndexModel : PageModel
    {
        private DBConnection _dBConnection;
        private readonly ILogger<IndexModel> _logger;

        public List<Hero> Heroes { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _dBConnection = new DBConnection();
            Heroes = new List<Hero>();
        }

        public void OnGet()
        {
            using(SqlConnection connection = new SqlConnection("Data Source=.\\MSSQLSERVER,1433;Initial Catalog=dreamBuilds;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                var cmd = new SqlCommand("SELECT * FROM Heroes", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while (reader.Read()) 
                    {
                        var hero = new Hero();
                        hero.id = reader.GetInt32(0);
                        hero.id_api = reader.GetInt32(1);
                        hero.name = reader.GetString(2);
                        hero.name_handle = reader.GetString(3);
                        hero.primary_attribute = reader.GetInt32(4);

                        Heroes.Add(hero);
                    }
                }
            }
        }
    }
}