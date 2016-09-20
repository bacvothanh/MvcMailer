using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mvc.Mailer;
using System.Web.Mvc;

namespace MyMailer.Mvc.Mailer
{
    public class KidMailer : MailerBase , IKidMailer
    {
        public MvcMailMessage RegisterSuccess()
        {
            var mailMessage = new MvcMailMessage {Subject = "Register success"};
            mailMessage.To.Add("bacvothanh1988@gmail.com");
            ViewBag.Name = "BacVT";

            PopulateBody(mailMessage, viewName: "RegisterSuccess");

            return mailMessage;
        }

        public MvcMailMessage ResetPasword()
        {
            throw new NotImplementedException();
        }
    }
}