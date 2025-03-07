using Demo1_MVC.Model;
using Microsoft.AspNetCore.Mvc;

namespace Demo1_MVC.Controllers
{
    public class MoviesController : Controller
    {
        //public string GetMovie()
        // {
        //     return "Hello Route :) ";
        // }

        //public RedirectResult Index2()
        //{
        //    RedirectResult result = new RedirectResult("http://localhost:39877/Movies/Index");

        //  return result;
        //}

        //public IActionResult Index3()
        //{
        //    return RedirectToAction(nameof(Index));


        //}



        //public IActionResult GetMovie(int id)
        //{
        //    return Content($"Movie with id :{id}");
        //}
        public IActionResult GetMovie(int id , string name , Employee employee)
        {
            return Content($"Movie with id :{id} ::: with name :{name}");
        }

    }
}
