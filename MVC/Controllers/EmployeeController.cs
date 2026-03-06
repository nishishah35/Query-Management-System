using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeInterface _repo;
        public EmployeeController(IEmployeeInterface repo) { _repo = repo; }


        public IActionResult EmpDashboard() => View();


        public IActionResult Dashboard() => View();

        [HttpGet]
        public async Task<JsonResult> GetUnsolvedQueries()
        {
            var data = await _repo.GetUnsolvedQueries();
            return Json(data);
        }


        [HttpGet]
        public async Task<JsonResult> GetPersonalMetrics()
        {
            int empId = HttpContext.Session.GetInt32("UserId") ?? 0;

            // Count how many queries this employee has solved
            int solvedCount = await _repo.GetResolvedCountByEmployee(empId);

            // Total unsolved queries currently in the system
            var allUnsolved = await _repo.GetUnsolvedQueries();
            int activeCount = allUnsolved.Count;

            return Json(new { solvedCount = solvedCount, activeCount = activeCount });
        }

        [HttpPost]
        public async Task<JsonResult> UpdateQueryStatus(int c_QueryId, string c_Status, string c_Comment)
        {
            int? empId = HttpContext.Session.GetInt32("UserId");
            if (empId == null) return Json(new { success = false, message = "Session Expired" });

            var success = await _repo.ResolveQuery(c_QueryId, empId.Value, c_Status, c_Comment);
            return Json(new { success });
        }

        public async Task<IActionResult> GetDashboardMetrics()
        {
            var stats = await _repo.GetQueryStats();
            var efficiency = await _repo.GetEmployeeResolutionMetrics();

            return Json(new
            {
                queryStats = stats,
                efficiencyData = efficiency
            });
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}