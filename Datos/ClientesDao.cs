namespace Datos
{
    using Entidades;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    public class ClientesDao : ConnectionToSql
    {
        public void SaveClient(Clientes cliente)
        {
            using (var conecction = GetConnection())
            {
                conecction.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conecction;
                    command.CommandText = "Insert into Clientes (Identificacion,Nombre,Apellido,Telefono,Correo,Peso,Altura,Activo,FechaReg,IdEntrenador) values" +
                        "(@identificacion,@nombre,@apellido,@telefono,@correo,@peso,@altura,@activo,@fechaReg,@idEntrenador)";
                    command.Parameters.AddWithValue("@identificacion",cliente.Identificacion);
                    command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    command.Parameters.AddWithValue("@correo", cliente.Correo);
                    command.Parameters.AddWithValue("@peso", cliente.PesoCliente);
                    command.Parameters.AddWithValue("@altura", cliente.AlturaCliente);
                    command.Parameters.AddWithValue("@activo", true);
                    command.Parameters.AddWithValue("@fechaReg", DateTime.Now);
                    command.Parameters.AddWithValue("@idEntrenador", cliente.IdEntrenador);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                conecction.Close();
            }
        }

        public bool GetClientByIdentificacion(string identificacion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand()) 
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Clientes where Identificacion = @identificacion";
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

        public List<Clientes> GetClientes()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                List<Clientes> clientes= new List<Clientes>();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Clientes";
                    command.CommandType= CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) 
                    {
                        while (reader.Read())
                        {
                            Clientes cliente = Mapear(reader);
                            clientes.Add(cliente);
                        }
                        return clientes;
                    }
                    return clientes;
                }
            }
        }

        private static Clientes Mapear(SqlDataReader reader)
        {
            return new Clientes()
            {
                IdClientes = (int)reader.GetInt64(0),
                Identificacion = reader.GetString(1),
                Nombre = reader.GetString(2),
                Apellido = reader.GetString(3),
                Telefono = reader.GetString(4),
                Correo = reader.GetString(5),
                PesoCliente = (decimal)reader.GetDecimal(6),
                AlturaCliente = (decimal)reader.GetDecimal(7),
                IdEntrenador = (int)reader.GetInt32(11),
                Edad = (int)reader.GetInt32(12),
            };
        }

        public Clientes GetClientById(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                Clientes cliente = new Clientes();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Clientes where IdCliente = @idCliente";
                    command.Parameters.AddWithValue("@idCliente", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cliente = Mapear(reader);
                        }
                    }
                    return cliente;
                }
            }
        }

        public void UpdateClient(Clientes cliente)
        {
            using (var conecction = GetConnection())
            {
                conecction.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conecction;
                    command.CommandText = "Update  Clientes set Nombre=@nombre,Apellido=@apellido,Edad=@Edad,Telefono=@telefono,Correo=@correo,Peso=@peso,Altura=@altura,IdEntrenador=@idEntrenador where IdCliente=@IdCliente";
                    command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("@Edad", cliente.Edad);
                    command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    command.Parameters.AddWithValue("@correo", cliente.Correo);
                    command.Parameters.AddWithValue("@peso", cliente.PesoCliente);
                    command.Parameters.AddWithValue("@altura", cliente.AlturaCliente);
                    command.Parameters.AddWithValue("@idEntrenador", cliente.IdEntrenador);
                    command.Parameters.AddWithValue("@idCliente", cliente.IdClientes);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                conecction.Close();
            }
        }
    }
}
