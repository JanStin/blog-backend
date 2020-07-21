using BlogSite.Domain.Entities;
using System.Collections.Generic;

namespace BlogSite.Models
{
    public class ArticleModel
    {
        
        public ArticleEntity Article { get; set; }
        
        
        public ArticleEntity Init(int id)
        {
            var connect = new Domain.MySqlConnect();
            
            List<object> list = new List<object>();
            list = connect.Query("articles", id);

            if (list.Count != 0)
            {
                Article = new ArticleEntity((int)list[0], (string)list[1], (string)list[2], (string)list[3], (string)list[4], (string)list[5], (string)list[6]);
                return Article;
            }
            else
            {
                return null;
            }
        }

    }

        // TODO: Сделать запрос в БД, чтобы получить статью по id.

}
