using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobs6Persistent.Data;
using TechJobs6Persistent.Models;
using TechJobs6Persistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobs6Persistent.Controllers
{
    public class EmployerController : Controller
    {
        private readonly JobDbContext context;

        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var employers = context.Employers.ToList();
            return View(employers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new AddEmployerViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult ProcessCreateEmployerForm(AddEmployerViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newEmployer = new Employer
                {
                    Name = model.Name,
                    Location = model.Location
                };

                context.Employers.Add(newEmployer);
                context.SaveChanges();

                return Redirect("/Employer");
            }

            return View("Create", model);
        }


        public IActionResult About(int id)
        {
            var employer = context.Employers.Find(id);

            if (employer == null)
            {
                return NotFound();
            }

            return View(employer);
        }
    }

}


