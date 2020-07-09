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
            if (id > 0)
            {
                article = new ArticleModel(id);
                return View("Index", article);
            }
            else
            {
                // TODO: Поменять на страницу ошибки.
                article = new ArticleModel(102);
                return View("Index", article);
            }
        }
    }
}
