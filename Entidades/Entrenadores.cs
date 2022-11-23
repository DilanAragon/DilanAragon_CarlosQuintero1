using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrenadores : Persona
    {
        public int CodigoEntrenador { get; set; }
        public Entrenadores()
        {

        }
        public override string ToString()
        {
            return $"{Nombre};{Telefono};{Correo};{CodigoEntrenador}";
        }
    }
}