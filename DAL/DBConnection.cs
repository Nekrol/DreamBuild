using Microsoft.Data.SqlClient;

namespace DreamBuild.DAL
{
    public class DBConnection
    {
        private readonly IConfiguration _configuration;

        public DBConnection()
        {
            //_configuration = configuration;
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection("Server=local;Database=dreamBuilds;Integrated Security=true;Trusted_Connection=True;TrustServerCertificate=True;");
        }


    }

}
