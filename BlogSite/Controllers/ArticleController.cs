using BlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class ArticleController : Controller
    {
        readonly private ArticleModel article = new ArticleModel();
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
