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
        private ArticleModel article = new ArticleModel();

        
        [Route("article/{id:int}")]
        public IActionResult Index(int id)
        {
            if (article.Init(id) == null)
            {
                return View("~/Views/Error/NotFound.cshtml");
            }           

            return View("Index", article);
        }
    }
}
