namespace Datos
{
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    public class EntrenadorDao : ConnectionToSql
    {
        public void SaveEntrenador(Entrenadores entrenador)
        {
            using (var conecction = GetConnection())
            {
                conecction.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conecction;
                    command.CommandText = "Insert into Entrenadors (Identificacion,Nombre,Apellido,Telefono,Correo,Activo,FechaReg,) values" +
                        "(@identificacion,@nombre,@apellido,@telefono,@correo,@activo,@fechaReg)";
                    command.Parameters.AddWithValue("@identificacion", entrenador.Identificacion);
                    command.Parameters.AddWithValue("@nombre", entrenador.Nombre);
                    command.Parameters.AddWithValue("@apellido", entrenador.Apellido);
                    command.Parameters.AddWithValue("@telefono", entrenador.Telefono);
                    command.Parameters.AddWithValue("@correo", entrenador.Correo);
                    command.Parameters.AddWithValue("@activo", true);
                    command.Parameters.AddWithValue("@fechaReg", DateTime.Now);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                conecction.Close();
            }
        }

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
                            Entrenadores entrenador = Mapear(reader);
                            entrenadores.Add(entrenador);
                        }
                        return entrenadores;
                    }
                    return entrenadores;
                }
            }
        }

        private static Entrenadores Mapear(SqlDataReader reader)
        {
            return new Entrenadores()
            {
                IdEntrenador = (int)reader.GetInt64(0),
                Identificacion = reader.GetString(1),
                Nombre = reader.GetString(2),
                Apellido = reader.GetString(3),
                Telefono = reader.GetString(4),
                Correo = reader.GetString(5),

            };
        }

        public Entrenadores GetEntrenadorById(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                Entrenadores entrenador = new Entrenadores();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Entrenadores where IdEntrenador = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            entrenador = Mapear(reader);
                        }
                    }
                    return entrenador;
                }
            }
        }
        public void UpdateEntrenador(Entrenadores entrenadores)
        {
            using (var conecction = GetConnection())
            {
                conecction.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conecction;
                    command.CommandText = "Update  Entrenadores set Nombre=@nombre,Apellido=@apellido,Telefono=@telefono,Correo=@correo";
                    command.Parameters.AddWithValue("@nombre", entrenadores.Nombre);
                    command.Parameters.AddWithValue("@apellido", entrenadores.Apellido);
                    command.Parameters.AddWithValue("@Edad", entrenadores.Edad);
                    command.Parameters.AddWithValue("@telefono", entrenadores.Telefono);
                    command.Parameters.AddWithValue("@correo", entrenadores.Correo);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                conecction.Close();
            }
        }

        public bool GetEntrenadorByIdentificacion(string identificacion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Entrenadores where Identificacion = @identificacion";
                    command.Parameters.AddWithValue("@identificacion", identificacion);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
