using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WideBotProject.Models
{
    public class FacebookCard
    {
        public string title { get; set; }
        public string image_url { get; set; }
        public string subtitle { get; set; }
        public DefaultAction default_action { get; set; }
        public List<Button> buttons { get; set; }

    }
}
