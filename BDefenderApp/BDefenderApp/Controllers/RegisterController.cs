using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BDefenderApp.Models;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace BDefenderApp.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RegisterController : Controller
    {
        private readonly DataContext _context;

        public RegisterController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<User>> RegisterUser(User userRegister)
        {
            var display = _context.Users.Where(u => u.Username == userRegister.Username).FirstOrDefault();
            if (display != null)
            {
                string Status = "Username already taken.";
                return BadRequest(Status);
            }
            else
            {
                _context.Users.Add(userRegister);
                await _context.SaveChangesAsync();
                string Status = "Registered successfully.";
                return Ok();
            }
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}
