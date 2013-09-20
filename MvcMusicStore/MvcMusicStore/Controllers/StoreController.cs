using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()";
        }

        // GET: /Store/Browse?genre=Disco
        public string Browse(string genre)
        {
            string sMessage = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            
            return sMessage;
        }

        // GET: /Store/Details/5
        public string Details(int id)
        {
            string sMessage = "Store.Details, ID = " + id;

            return sMessage;
        }
    }
}
