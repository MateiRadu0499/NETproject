using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BDefenderApp.Models;

namespace BDefenderApp.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return BadRequest();
        }

        [HttpPost]
        public ActionResult Index(Login objuserlogin)
        {
            var display = _context.Users.Where(u => (u.Username == objuserlogin.Username && u.Password == objuserlogin.Password)).FirstOrDefault();
            if(display != null)
            {
                ViewBag.Status = "Authenticated succesfully.";
            }
            else
            {
                ViewBag.Status = "Incorrect username or password.";
            }
            return Ok();
        }
   
    }
}
