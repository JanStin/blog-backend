using BlogSite.Interfaces;
using BlogSite.Models;
using BlogSite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class HomeController : Controller
    {

        private readonly IAllPosts _posts;

        public HomeController(IAllPosts posts)
        {
            _posts = posts;
        }

        public ViewResult Index()
        {
            var homePosts = new HomeViewModel
            {
                Posts = _posts.Posts
            };

            return View(homePosts);
        }
    }
}
