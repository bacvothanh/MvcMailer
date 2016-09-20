using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMailer.Mvc.Mailer;

namespace MyMailer.Mvc.Controllers
{
    public class MailController : Controller
    {
        private readonly IKidMailer _kidMailer;
        public MailController()
        {
            // Resolve dependency
            _kidMailer = new KidMailer();

        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            _kidMailer.RegisterSuccess().Send();

            return View();
        }

       
    }
}