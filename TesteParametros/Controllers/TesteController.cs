using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteParametros.Controllers
{
    public class TesteController : Controller
    {
        //
        // GET: /Teste/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TesteReturn(parameters param) 
        {            
            return Json(param, JsonRequestBehavior.AllowGet);
        }

    }

    public class parameters 
    {
        public A _A { get; set; }
        public B _B { get; set; }
    }

    public class A 
    {
        public int A1 { get; set; }
        public int A2 { get; set; }
        public int A3 { get; set; }
    }

    public class B
    {
        public int B1 { get; set; }
        public int B2 { get; set; }
        public int B3 { get; set; }
    }
}
