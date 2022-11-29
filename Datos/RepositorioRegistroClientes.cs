using Entidades;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datos
{
    public class RepositorioRegistroClientes : Archivos, ICrudArchivos<Clientes>
    {
        public RepositorioRegistroClientes(string fileName) : base(fileName)
        {

        }

        public List<Clientes> GetAll()
        {
            try
            {
                List<Clientes> clientela = new List<Clientes>();
                FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    clientela.Add(Mapper(sr.ReadLine()));
                }
                sr.Close();
                return clientela;
            }
            catch (Exception)
            {

                return null;
            }

        }
        public Clientes Mapper(string linea)
        {
            try
            {
                var registro = new Clientes();
               
                registro.Nombre = (linea.Split('|')[1]);
                registro.AlturaCliente = int.Parse(linea.Split('|')[2]);
                registro.PesoCliente = int.Parse(linea.Split('|')[3]);
                registro.Telefono = (linea.Split('|')[4]);
                registro.Correo = (linea.Split('|')[5]);
                
                return registro;

            }
            catch (Exception)
            {
                return null;
            }

        }

       

        public bool Update(List<Clientes> registro)
        {
            try
            {
                var sw = new StreamWriter(ruta, false);
                foreach (var item in registro)
                {
                    sw.WriteLine(item.ToString());
                }

                sw.Close();

                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }
    }
}
