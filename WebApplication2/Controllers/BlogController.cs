using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var db = new BlogContext();
            
            return View(db.Blogs.ToList());
        }
    }
}
