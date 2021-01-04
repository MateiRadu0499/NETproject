using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BDefenderApp.Models;

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
        [HttpGet]
        public ActionResult Index()
        {
            return BadRequest();
        }

        [HttpPost]
        public ActionResult Index(Register objuserlogin)
        {
            var display = _context.Users.Where(u => u.Username == objuserlogin.Username).FirstOrDefault();
            if (display != null)
            {
                ViewBag.Status = "Username already taken.";
            }
            else
            {
                //write his credentials in the database
                ViewBag.Status = "Registered successfully.";
            }
            return Ok();
        }

    }
}
