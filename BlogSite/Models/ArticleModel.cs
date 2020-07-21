using BlogSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BlogSite.Models
{
    public class ArticleModel
    {
        
        public ArticleEntity Article { get; set; }
        
        
        public ArticleEntity Init(int id)
        {
            var connect = new Domain.MySqlConnect();
            var connection = new MySqlConnection(connect.Connect());

            MySqlCommand query = connection.CreateCommand();
            query.CommandText = $"SELECT * FROM articles WHERE id = {id}";
            connection.Open();

            MySqlDataReader result = query.ExecuteReader();
            if (result.Read())
            {
                Article = new ArticleEntity(result.GetInt32(0), result.GetString(1), result.GetString(2), result.GetString(3), result.GetString(4), result.GetString(5), result.GetString(6));
                connection.Close();
                return Article;
            }
            else
            {
                connection.Close();
                return null;
            }
        }

    }

        // TODO: Сделать запрос в БД, чтобы получить статью по id.

}
