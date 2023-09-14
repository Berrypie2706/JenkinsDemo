using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User(){UserID = 1, UserName = "Saket", UserPwd = "Saket@12", UserEmail = "saket1@yahoo.com"},
            new User(){UserID = 2, UserName = "Aman", UserPwd = "Aman@12", UserEmail = "aman1@yahoo.com"},
            new User(){UserID = 3, UserName = "Himanshu", UserPwd = "Him@12", UserEmail = "himanshu1@yahoo.com"},
            new User(){UserID = 4, UserName = "Akash", UserPwd = "Akash@12", UserEmail = "akash1@yahoo.com"},
            new User(){UserID = 5, UserName = "Arvind", UserPwd = "Arvind@12", UserEmail = "arvind@yahoo.com"}
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                users.Add((model));
            }
            else
            {
                return View(model);
            }
            return RedirectToAction("Index");
        }
    }
}
