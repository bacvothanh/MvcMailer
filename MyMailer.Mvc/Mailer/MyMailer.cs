using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mvc.Mailer;

namespace MyMailer.Mvc.Mailer
{
    public class MyMailer : MailerBase
    {
        public virtual MvcMailMessage Welcome()
        {
            return Populate(x => {
                x.ViewName = "Welcome";
                x.To.Add("bacvothanh1988@gmail.com");
                x.Subject = "Welcome";
            });
        }

    }
}