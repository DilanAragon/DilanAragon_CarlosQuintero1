using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
        public class ServicioRegistroClientes : IServices<Clientes>
        {
            List<Clientes> clientela ;
            RepositorioRegistroClientes repositorioRegistroClientes;
            public ServicioRegistroClientes()
            {
                repositorioRegistroClientes = new RepositorioRegistroClientes("Clientes.txt");

                clientela =  new List<Clientes>();
            }
            void Refresh()
            {
                clientela = repositorioRegistroClientes.GetAll();
            }
            public string Save(Clientes registro)
            {
                //validar
                if (GetById(registro.Id) != null)
                {
                    return "contacto ya existe con este numero de telefono";
                }
                // fin validar

                var estado = repositorioRegistroClientes.Guardar(registro);

                //Refresh();

                return estado ? $"el contacto se agrego correctamente con el nombre {registro.Nombre}" :
                                     $"ERROR al Guardar el contacto con el nombre {registro.Nombre}";
            }

            public string Delete(Clientes registro)
            {
                clientela.Remove(registro);
                repositorioRegistroClientes.Update(clientela);
                Refresh();
                return $"el contacto se elimino correctamente con el nombre {registro.Nombre}";
            }

            public string Edit(Clientes oldRegistro, Clientes UpdateRegistro)
            {
                oldRegistro.Id = UpdateRegistro.Id;
                oldRegistro.Nombre = UpdateRegistro.Nombre;
                oldRegistro.AlturaCliente = UpdateRegistro.AlturaCliente;   
                oldRegistro.Telefono = UpdateRegistro.Telefono;
                oldRegistro.PesoCliente = UpdateRegistro.PesoCliente;
                oldRegistro.Correo = UpdateRegistro.Correo;
                var estado = repositorioRegistroClientes.Update(clientela);
                Refresh();
                return estado ? $"se actulizo el contacto {UpdateRegistro.Nombre}" : $"ERROR al actulizar el contacto {UpdateRegistro.Nombre}";
            }

            public bool Exist(Clientes registro)
            {
                foreach (var item in clientela)
                {
                    if (item.Id == registro.Id)
                    {
                        return true;
                    }
                }
                return false;
            }

            public List<Clientes> GetAll()
            {
                return clientela;
            }

            public Clientes GetById(string id)
            {
                List<Clientes> clientS = repositorioRegistroClientes.GetAll();
                foreach (var item in clientS)
                {
                    if (item.Id == id)
                    {
                        return item;
                    }
                }
                return null;
            }

            public Clientes GetByPhone(string phone)
            {
                foreach (Clientes item in clientela)
                {
                    if (item.Telefono == phone)
                    {
                        return item;
                    }
                }
                return null;
            }


        }
}
