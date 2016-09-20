using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvc.Mailer;

namespace MyMailer.Mvc.Mailer
{
    public interface IKidMailer
    {
        MvcMailMessage RegisterSuccess();
        MvcMailMessage ResetPasword();
    }
}
