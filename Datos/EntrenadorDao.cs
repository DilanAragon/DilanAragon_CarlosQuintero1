using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EntrenadorDao : ConnectionToSql
    {
        public List<Entrenadores> GetEntrenadores()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                List<Entrenadores> entrenadores = new List<Entrenadores>();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Entrenadores";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Entrenadores entrenador = new Entrenadores()
                            {
                                IdEntrenador = (int)reader.GetInt64(0),
                                Identificacion = reader.GetString(1),
                                Nombre = reader.GetString(2),
                                Apellido = reader.GetString(3),
                                Telefono = reader.GetString(4),
                                Correo = reader.GetString(5),

                            };
                            entrenadores.Add(entrenador);
                        }
                        return entrenadores;
                    }
                    return entrenadores;
                }
            }
        }
    }
}
