using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WideBotProject.Models;
using WideBotProject.Utils;

namespace WideBotProject.Controllers
{
    public class WidebotController : Controller
    {
        [Route("widebot")]
        public string Index()
        {
            return "Hey there";
            //return View();
        }

        [Route("widebot/get")]
        public string Get()
        {
            Uri targetUri = new Uri("https://reqres.in/api/users");

            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(targetUri);

            var response = request.GetResponse() as HttpWebResponse;

            var reader = new StreamReader(response.GetResponseStream());

            var objText = reader.ReadToEnd();

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            var ser = serializer.Deserialize<JsonModel>(objText);

            Utilities utilities = new Utilities();

            Attributes attribute = utilities.getAttribute(ser);

            List<FacebookCard> facebookCards = utilities.convertToWideBot(ser);

            WideBotAPI wideBotAPI = new WideBotAPI { attributes = attribute, flowName = ser.support, FacebookResponse = facebookCards};

            var json = new JavaScriptSerializer().Serialize(wideBotAPI);

            return json;
        }
    }
}
