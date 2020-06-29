using BlogSite.Interfaces;
using BlogSite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class BlogPageController : Controller
    {
        private IAllPosts _posts;

        public BlogPageController(IAllPosts posts)
        {
            _posts = posts;
        }

        public ViewResult Index()
        {
            var blogPosts = new BlogPageViewModel
            {
                Posts = _posts.Posts
            };

            return View(blogPosts);

        }
    }
}
