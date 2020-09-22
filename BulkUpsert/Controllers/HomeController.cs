using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BulkUpsert.Models;
using BulkUpsert.Data;
using EFCore.BulkExtensions;

namespace BulkUpsert.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            List<Employee> employee = new List<Employee>();

            employee = UpdateRecord();
            _db.BulkUpdate(employee);
            //employee = InsertRecord();
            //_db.BulkInsert(employee);

            employee = _db.Employees.Take(_db.Employees.Count() / 2).ToList();
            _db.BulkDelete(employee);
            return View();
        }

        public static List<Employee> InsertRecord()
        {
            List<Employee> list = new List<Employee>();
            for(int i = 0; i < 10000; i++)
            {
                list.Add(new Employee()
                {
                    Name = "Employee_" + i,
                    Department = "Department_" + i,
                    City = "City_" + i
                });
            }

            return list;
        }

        public static List<Employee> UpdateRecord()
        {
            List<Employee> updateList = new List<Employee>();

            for(int i = 0; i < 100000; i++)
            {
                updateList.Add(new Employee()
                {
                    Id = (i + 1),
                    Name = "New Employe_" + i,
                    Department = "New Department_" + i,
                    City = "New City_" + i

                }); ;

            }
            return updateList;
        }

        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
