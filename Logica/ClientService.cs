namespace Logica
{
    using Datos;
    using Entidades;
    using System;
    using System.Collections.Generic;

    public class ClientService
    {
        readonly ClientesDao clientesDao;
        public ClientService()
        {
            clientesDao = new ClientesDao();
        }

        public string SaveClient(Clientes cliente)
        {
            try
            {
                bool response = clientesDao.GetClientByIdentificacion(cliente.Identificacion.Trim());
                if (response) 
                {
                    return $"El cliente con identificacion {cliente.Identificacion} ya se encuentra registrado";
                }
                clientesDao.SaveClient(cliente);
                return "Cliente registrado con exito";
            }
            catch (Exception e)
            {
                return "Error" + e.Message;
            }
        }

        public List<Clientes> GetClientes()
        {
            try
            {
                return clientesDao.GetClientes();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Clientes GetClientById(int id)
        {
            try
            {
                Clientes cliente = clientesDao.GetClientById(id);
                return cliente;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
