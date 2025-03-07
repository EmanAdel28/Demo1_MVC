using Microsoft.AspNetCore.Mvc;

namespace Demo1_MVC.Controllers
{
    public class MoviesController : Controller
    {
        //public string GetMovie()
        // {
        //     return "Hello Route :) ";
        // }

        public ContentResult Index()
        {
            ContentResult result = new ContentResult();
            result.Content = "Black Adam";
            return result;
        }

        public RedirectResult Index2()
        {
            RedirectResult result = new RedirectResult("http://localhost:39877/Movies/Index");
            
          return result;
        }

        public IActionResult Index3()
        {
            return RedirectToAction(nameof(Index));


        }
    }
}
