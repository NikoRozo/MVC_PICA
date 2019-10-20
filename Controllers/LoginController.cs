using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_PICA.Models;

namespace MVC_PICA.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login(LoginModel model)
        {
            return View();
        }
        [Authorize("Login")]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ActionLogin(LoginModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                if (model.UserName == "Admin" && model.Password == "123")
                {
                    return Redirect("/Login/Index");
                }
            }
            // At this point, something failed, redisplay form
            model.logins += 1;
            return View("Login",model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
