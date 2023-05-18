using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WEBAPI_E2.Models;

namespace WEBAPI_E2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public RegistrationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("registration")]
        public string registration(RegistrationModel registration)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("LearnDB").ToString());
            SqlCommand cmd = new SqlCommand("Insert into registration(UserName,PassWord,Email,IsActive) Values('"+registration.UserName+"','"+registration.Password+"','"+registration.Email+"','"+registration.IsActive+"')", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return "Data Inserted";
            }
            else
            {
                return "Not inserted";
            }
        }
    }
}
