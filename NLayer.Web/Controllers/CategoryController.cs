using Microsoft.AspNetCore.Mvc;

namespace NLayer.Web.Controllers
{
    public class CategoryController :Controller
    {

        public IActionResult Index()
        {

            return View("Category");

        }



    }
}
