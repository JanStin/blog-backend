using BlogSite.Interfaces;
using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Mocks
{
    public class MockCategory : IPostsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ Name = "C#", Description = "Категория C# разработки"},
                    new Category{ Name = "Web", Description = "Категория Web разработки"}
                };
            }
        }
    }
}
