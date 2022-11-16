using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad_Blockchain
{
    public class ConnectionMySql
    {
        /// <summary>
        /// Instancia la coneccion con la base de datos
        /// </summary>
        /// <returns>Retorna la coneccion a la base de datos</returns>
        public static MySqlConnection getConnection()
        {
            MySqlConnection connect = new MySqlConnection("server=localhost; database=librodm; Uid=root; pwd=;");
            connect.Open();
            return connect;
        }

        /// <summary>
        /// Cierra la coneccion la base de datos
        /// </summary>
        /// <param name="connection">Trae la instancia de la base de datos</param>
        public static void closeConnection(MySqlConnection connection)
        {
            connection.Close();
        }
    }
}
