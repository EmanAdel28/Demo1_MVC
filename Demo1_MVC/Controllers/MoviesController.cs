using Microsoft.AspNetCore.Mvc;

namespace Demo1_MVC.Controllers
{
    public class MoviesController : Controller
    {
       public string GetMovie()
        {
            return "Hello Route :) ";
        }
    }
}
