using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePenCo_.Controllers
{
    public class ThePenCo : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        /*public string Index()
        {
            return "This is my default action...";
        }*/

        // 
        // GET: /HelloWorld/Welcome/ 

        /*public string Welcome()
        {
            return "This is the Welcome action method...";
        }*/
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
