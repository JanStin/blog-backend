namespace BlogSite.Domain
{
    public class MySqlConnect
    {
        private const string Host = "localhost";
        private const string Database = "blog";
        private const string User = "root";
        private const string Password = "root";

        public string Connect()
        {
            return $"Database= {Database};Datasource={Host};User={User};Password={Password}";
        }
    }
}
