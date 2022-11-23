namespace Datos
{
    using Entidades;
    using System;
    using System.IO;

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
        public bool Guardar(Persona registro)
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
