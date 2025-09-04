using Dashboard.Brokers.Storages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Controllers
{
    public class StudentController:Controller
    {
        private readonly StorageBroker broker;

        public StudentController(StorageBroker broker)
        {
            this.broker = broker;
        }

        public async Task<IActionResult> Chart()
        {
            var students = await broker.Students.OrderBy(x => x.GPA).ToListAsync();
            return Json(students);
        }

        public async Task<IActionResult> ChartByBirthYear()
        {
            var students = await broker.Students.ToListAsync();

            var data = students
                .GroupBy(s => s.BirthDate.Year)
                .Select(g => new
                {
                    Year = g.Key,
                    AvgGpa = Math.Round(g.Average(s => s.GPA), 2) 
                })
                .OrderBy(x => x.Year)
                .ToList();

            return Json(data);
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChartGpa()
        {
            return View();
        }

        public IActionResult ChartBalance()
        {
            return View();
        }

        public IActionResult ChartActiveInactive()
        {
            return View();
        }

        public IActionResult GpaYear()
        {
            return View();
        }
    }
}
