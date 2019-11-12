using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sample.WebApiDemo.Controllers
{
    public class WebController : ApiController
    {
        public static List<string> Items = new List<string> { "item1", "item2", "item3", "item4" };

        [HttpGet]
        public IEnumerable<string> GetItems()
        {
            return Items;
        }

        [HttpGet]
        public string GetItemByIndex(int id)
        {
            return Items[id];
        }
    }
}
