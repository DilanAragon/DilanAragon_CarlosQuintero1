using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivos
    {
        protected string ruta;
        public Archivos(string fileNme)
        {
            ruta = fileNme;
        }
        public Archivos()
        {
            ruta = "Registros.TXT";
        }
        public bool Guardar(Entidades.Persona registro)
        {
            try
            {
                FileStream file = new FileStream(ruta, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine(registro.ToString());
                sw.Close();
                file.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
