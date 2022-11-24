using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes : Persona
    {
        public int PesoCliente { get; set; }
        public int AlturaCliente { get; set; }
        public int Mensualidad { get; set; }

        public Clientes()
        {

        }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono};{AlturaCliente};{PesoCliente};{Correo};{Mensualidad}";
        }
    }
    
}