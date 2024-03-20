using MySql.Data.MySqlClient;

namespace Diary
{
    internal class DataBase
    {
        // MySql(система управления бд) connector и MAMP для создания локального сервера с бд.
        public MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=diary");

        // открывает соединение с базой данных
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // закрывает соединение с базой данных
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // возвращает само соединение
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}