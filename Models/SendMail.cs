using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SendMailWithAjaxCall.Models
{
    public class SendMail
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Name { get; set; }
    }
}