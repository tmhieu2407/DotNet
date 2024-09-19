using Models1;
using MVC.Areas.Admin.Code;
using MVC.Areas.Admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public ActionResult Index(Login_NetModels models)
        {
            var result = new LoginModels().Login(models.Username, models.PasswordHash);
            if(result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() {Username = models.Username });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tài khoản mật khẩu không đúng!");
            }
            return View(models);
        }
    }
}