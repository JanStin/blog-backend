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
        private ArticleModel article;

        [Route("article/{id}")]
        public IActionResult Index(int id)
        {
            article = new ArticleModel(id);
            return View(article);
        }
    }
}
