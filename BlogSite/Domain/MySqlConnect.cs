using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace BlogSite.Domain
{
    public class MySqlConnect
    {
        private const string Host = "localhost";
        private const string Database = "blog";
        private const string User = "root";
        private const string Password = "root";

        private string Connect()
        {
            return $"Database= {Database};Datasource={Host};User={User};Password={Password}";
        }

        public List<object> Query(string table, int id)
        {
            var connection = new MySqlConnection(Connect());
            
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = $"SELECT * FROM {table} WHERE id = {id}";
            
            connection.Open();

            MySqlDataReader result = query.ExecuteReader();
            
            List<object> resultList = new List<object>();

            if (result.Read())
            {   
                for(var i = 0; i < result.FieldCount; i++)
                {
                    resultList.Add(result.GetValue(i));
                }
            }
            connection.Close();

            return resultList;
        }
    }
}
