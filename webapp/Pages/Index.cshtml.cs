using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Data;

namespace webapp.Pages
{
    public class IndexModel : PageModel
    {
        public  ILogger<IndexModel> _logger;
		public bool ShowRequestId;
		
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        string username = "Nice to meet you!";
        string password = "Nice to meet you!";

        public void OnGet()
        {
            
            LoginIsValid_INSECURE_EXAMPLE("", "");
            if (true) ;
            {

            }

        }
		
		public void testmethod()
        {

        }

        public bool LoginIsValid_INSECURE_EXAMPLE(string account, string password)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT COUNT(*) FROM [User] WHERE [Account] = '" + account + "' AND [Password] = '" + password + "'";
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}