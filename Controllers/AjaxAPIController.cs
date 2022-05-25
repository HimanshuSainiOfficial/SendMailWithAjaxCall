using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using SendMailWithAjaxCall.Models;
namespace SendMailWithAjaxCall.Controllers
{
    public class AjaxAPIController : ApiController
    {
        [Route("api/AjaxAPI/SendEmail")]
        [HttpPost]
        public string SendEmail(SendMail email)
        {
            using (MailMessage mm = new MailMessage("himanshu01.monarch@gmail.com", email.Email))
            {
                try
                {
                    mm.Subject = email.Subject;
                    mm.Body = "Hi ," + email.Name + "  This Is Your Test Demo Of SMTP Mail Send Using WebApi In Asp Dot Net" + " And This Is Your Body Of Mail - " + email.Body;

                    mm.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        NetworkCredential networkCred = new NetworkCredential("himanshu01.monarch@gmail.com", "dhnf vudq nzgj hhug");
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = networkCred;
                        smtp.Port = 587;
                        smtp.Send(mm);
                    }
                }
                catch (Exception ex) 
                {

                }
                
            }

            return "Email sent sucessfully.";
        }
    }
}
