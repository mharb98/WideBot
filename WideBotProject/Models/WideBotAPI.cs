using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WideBotProject.Models
{
    public class WideBotAPI
    {
        public Attributes attributes { get; set; }
        public Support flowName { get; set; }
        public List<FacebookCard> FacebookResponse { get; set; }

    }
}
