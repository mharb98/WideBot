using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WideBotProject.Models
{
    public class JsonModel
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<User> data { get; set; }
        public Support support { get; set; }
    }
}
