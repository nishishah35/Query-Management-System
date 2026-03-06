using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using Repository.Models;

namespace MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountInterface _authRepo;

        public AccountController(IAccountInterface authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            // 1. Check if Employee (Admin or Staff)
            var emp = await _authRepo.LoginEmployee(email, password);
            if (emp != null)
            {
                HttpContext.Session.SetInt32("UserId", emp.c_EmpId);
                HttpContext.Session.SetString("UserName", emp.c_EmpName ?? "");
                HttpContext.Session.SetString("UserRole", emp.c_Role ?? "employee");

                return Json(new { success = true, role = emp.c_Role });
            }

            // 2. Check if Regular User
            var user = await _authRepo.LoginUser(email, password);
            if (user != null)
            {
                HttpContext.Session.SetInt32("UserId", user.c_UserId);
                HttpContext.Session.SetString("UserName", user.c_CompanyName ?? "");
                HttpContext.Session.SetString("UserRole", "user");

                return Json(new { success = true, role = "user" });
            }

            return Json(new { success = false, message = "Invalid email or password" });
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}