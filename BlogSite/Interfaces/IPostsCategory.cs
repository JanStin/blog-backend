using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Interfaces
{
    public interface IPostsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
