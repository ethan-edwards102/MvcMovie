using Microsoft.AspNetCore.Mvc;

namespace MvcMovie
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorldController
        public ActionResult Index()
        {
            return View();
        }

    }
}
