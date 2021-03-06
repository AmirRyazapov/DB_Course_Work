using MySql.Data.MySqlClient;

namespace DBCourseWork
{
    class DB_Connection
    {
        MySqlConnection connection = new MySqlConnection("SSL Mode = None; server = localhost; port = 3306; username = root; password = ; database = DBCourseWork;");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
