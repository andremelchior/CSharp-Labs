using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "localhost";
            string uid = "root";
            string pass = "";
            MySqlConnection conn = new MySqlConnection($"server={server};uid={uid};password={pass}");

            try
            {
                conn.Open();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            // TIPOS DE OBJETOS DE MYSQL:
            // - Conexão (MySqlConnection)
            // - Script SQL (MySqlCommand)
            // - Leitura de script SQL (MySqlDataReader)
        }
    }
}
