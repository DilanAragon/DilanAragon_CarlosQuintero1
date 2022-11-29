using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes : Persona
    {
        public decimal PesoCliente { get; set; }
        public decimal AlturaCliente { get; set; }
        public int IdClientes { get; set; }
        public int IdEntrenador { get; set; }
        public Clientes()
        {

        }

        public override string ToString()
        {
            return $"{Identificacion};{Nombre};{Telefono};{AlturaCliente};{PesoCliente};{Correo}";
        }
    }
    
}