using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioRegistroEntrenadores : Archivos, ICrudArchivos<Entrenadores>
    {
        public RepositorioRegistroEntrenadores(string fileName) : base(fileName)
        {

        }

        public List<Entrenadores> GetAll()
        {
            try
            {
                List<Entrenadores> entrenadoresl = new List<Entrenadores>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    entrenadoresl.Add(Mapper(sr.ReadLine()));
                }
                sr.Close();
                return entrenadoresl;
            }
            catch (Exception)
            {

                return null;
            }

        }
        public Entrenadores Mapper(string linea)
        {
            try
            {
                var registro = new Entrenadores();
               // registro.Id = (linea.Split(';')[0]);
                registro.Nombre = (linea.Split(';')[1]);
                registro.Telefono = (linea.Split(';')[2]);
                registro.Correo = (linea.Split(';')[3]);
               // registro.CodigoEntrenador = int.Parse(linea.Split(';')[4]);
                

                return registro;

            }
            catch (Exception)
            {
                return null;
            }

        }

        public bool Update(List<Entrenadores> registro)
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
