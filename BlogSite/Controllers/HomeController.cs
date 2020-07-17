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

        public ViewResult Index()
        {


            return View();
        }
    }
}
