using BlogSite.Interfaces;
using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Mocks
{
    public class MockPosts : IAllPosts
    {
        private readonly IPostsCategory _postsCategory = new MockCategory();

        public IEnumerable<Post> Posts
        {
            get
            {
                return new List<Post>
                {
                    new Post{Title = "Основы Asp.net",
                             Description = "Основы Asp.net core описываются непосредственно в этом посте",
                             ShortDescription = "В это посте основы Asp.net",
                             Modified = null,
                             PostedOn = new DateTime(2020, 6, 29),
                             Published = true,
                             Tags = new List<string>
                             {
                                 "asp.net",
                                 "C#"
                             },
                             Category = _postsCategory.AllCategories.First()
                    },
                    new Post{Title = "Основы Html",
                             Description = "Основы Html описываются непосредственно в этом посте",
                             ShortDescription = "В это посте основы Html",
                             Modified = null,
                             PostedOn = new DateTime(2020, 6, 29),
                             Published = true,
                             Tags = new List<string>
                             {
                                 "Html"
                             },
                             Category = _postsCategory.AllCategories.Last()
                    },
                    new Post{Title = "Основы Css",
                             Description = "Основы Css описываются непосредственно в этом посте",
                             ShortDescription = "В это посте основы Css",
                             Modified = null,
                             PostedOn = new DateTime(2020, 6, 29),
                             Published = true,
                             Tags = new List<string>
                             {
                                 "html",
                                 "Css"
                             },
                             Category = _postsCategory.AllCategories.Last()
                    }
                };
            }
        }

        public Post GetObjectPost(int postId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPostByTags(IEnumerable<string> Tags)
        {
            throw new NotImplementedException();
        }
    }
}
