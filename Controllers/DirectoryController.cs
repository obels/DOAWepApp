using DOAWepApp.Models;
using DOAWepApp.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOAWepApp.Controllers
{
    public class DirectoryController : Controller
    {
        private readonly DOADBContext _context;
        public DirectoryController()
        {
            _context = new DOADBContext();
        }

        // GET: Directory
        public ActionResult EmployeeList()
        {

            var dataBase = _context.EmployeeDb.ToList();

           return View(dataBase);
        }
        public ActionResult GetEmployeeList()
        {
            return Content("Test");
        }
    }
}