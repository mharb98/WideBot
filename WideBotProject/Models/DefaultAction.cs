using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WideBotProject.Models
{
    public class DefaultAction
    {
        private string email;
        public string type { get; set; }
        public Uri targetUri { get; set; }
        public string webview_height_ratio { get; set; }
        public DefaultAction(string email)
        {
            this.email = email;

            this.type = "web_url";

            string dummy = "https://mail.google.com/mail/u/0/?fs=1&tf=cm&to=" + this.email + "&su=Hello&body=Send%20Email";

            this.targetUri = new Uri(dummy);

            this.webview_height_ratio = "tall";
        }
    }
}
