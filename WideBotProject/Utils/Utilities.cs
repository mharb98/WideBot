using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WideBotProject.Models;

namespace WideBotProject.Utils
{
    public class Utilities
    {
        public Utilities() { }

        public Attributes getAttribute(JsonModel ser)
        {
            int page = ser.page;
            int per_page = ser.page;
            int total = ser.total;
            int total_pages = ser.total_pages;

            Attributes attribute = new Attributes { page = page, per_page = per_page, total = total, total_pages = total_pages};

            return attribute;
        }

        public List<FacebookCard> convertToWideBot(JsonModel ser)
        {
            List<User> users = ser.data;

            string email = null;
            string first_name = null;
            string last_name = null;
            string avatar = null;
            DefaultAction default_action = null;
            Button button = null;
            FacebookCard facebook_card = null;

            List<FacebookCard> facebookCards = new List<FacebookCard>();

            List<Button> buttons;

            foreach(var user in users)
            {
                email = user.email;
                first_name = user.first_name;
                last_name = user.last_name;
                avatar = user.avatar;
                buttons = new List<Button>();

                default_action = new DefaultAction(email);
                button = new Button(email);

                buttons.Add(button);

                facebook_card = new FacebookCard { title = first_name, image_url = avatar, subtitle = last_name,
                    default_action = default_action, buttons = buttons };

                facebookCards.Add(facebook_card);

            }

            return facebookCards;
        }
    }
}
