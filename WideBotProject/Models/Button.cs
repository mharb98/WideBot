using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WideBotProject.Models
{
    public class Button
    {
        private string email;
        public string type { get; set; }
        public Uri targetUri { get; set; }
        public string title { get; set; }
        public Button(string email)
        {
            this.email = email;

            this.type = "web_url";

            string dummy = "https://mail.google.com/mail/u/0/?fs=1&tf=cm&to=" + this.email + "&su=Hello&body=Send%20Email";

            this.targetUri = new Uri(dummy);

            this.title = "Send Email";
        }
    }
}
