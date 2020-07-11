using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationUnitTest.Controllers
{
    public class checkEmployee
    {
        public virtual Boolean checkEmp()
        {
            throw new NotImplementedException();
        }
    }

    public class processEmployee
    {
        public Boolean insertEmployee(checkEmployee objtmp)
        {
            objtmp.checkEmp();
            return true;
        }
    }
    public class HomeController : Controller
    {
        public string concat(string lastname, string firstname)
        {
            string name = String.Concat(lastname, firstname);
            return name;
        }

        private int Add(int a, int b)
        {
            return a + b;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}