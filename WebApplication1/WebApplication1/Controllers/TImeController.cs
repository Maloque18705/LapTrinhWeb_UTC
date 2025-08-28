using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplication1.Controllers
{
    public class TImeController : Controller
    {
        //
        // GET: /Time/
        public string Index()
        {
            return "Default";
        }
        // 
        // GET: /Time/Welcome/
        public string Welcome(string name, int numTimes = 1)
        {
            name = "Son";
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
