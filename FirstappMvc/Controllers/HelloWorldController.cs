using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace FirstappMvc.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This Default action...";
        }

        public string Welcome()
        {
            return "This Welcome action!";
        }
    }
}