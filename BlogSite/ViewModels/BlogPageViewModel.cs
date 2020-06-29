using BlogSite.Interfaces;
using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.ViewModels
{
    public class BlogPageViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}
