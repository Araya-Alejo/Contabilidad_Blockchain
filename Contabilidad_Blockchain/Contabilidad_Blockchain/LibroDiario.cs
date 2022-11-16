using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad_Blockchain
{
    internal class LibroDiario
    {
        MySqlConnection connectionSeat = ConnectionMySql.getConnection(); // Abre conexión
        MySqlCommand commandSeat = new MySqlCommand(String.Format("SELECT * FROM account"), connectionSeat); // Envía Query
        MySqlDataReader reader = (MySqlDataReader)commandSeat.ExecuteReader(); // Estable un lector (reader)

            while (reader.Read()) // Lee filas de lo que recupera de la BD
            {
                List<Account> valores = new List<Account>();
        accounts.Add(new Account(reader.GetString(1), valores)); // Guarda las cuentas recuperadas
            }

    ConnectionMySql.closeConnection(connectionSeat); // Se cierra conexión

    }
}
