using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class PresentacionCP
    {
        public void EjecutarAgregar()
        {
            Console.Clear();
            var persona  = ComunInput();

            Console.SetCursorPosition(40, 10); Console.WriteLine("Digite el peso del cliente: ");
            Console.SetCursorPosition(74, 10); int peso = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(40, 12); Console.WriteLine("Digite la Altura del cliente: ");
            Console.SetCursorPosition(76, 12); int Altura = int.Parse(Console.ReadLine());

            


            Clientes clientela = new Clientes()
            {
                Nombre = persona.Nombre,
                Telefono = persona.Telefono,
                PesoCliente = peso,
                AlturaCliente = Altura,
                Correo = persona.Correo,
                Id = persona.Id,
            };
            new Logica.ServicioRegistroClientes().Save(clientela);

            Console.SetCursorPosition(50,8);Console.ReadKey();
        }
        public void EjecutarAgregarEntrenadores()
        {
            Console.Clear();
            var persona = ComunInput();
            Console.WriteLine("Digite El Codigo Del Entrenador: ");

        }
            public Persona ComunInput()
            {
                Console.WriteLine("* * * * * * * * * * * * * * * * * *");
                Console.WriteLine("Digite el id : ");
                 string id = Console.ReadLine();

                Console.WriteLine("Digite el nombre: ");
                string nombre = Console.ReadLine();

               Console.WriteLine("Digite el telefono: ");
               string telefono = Console.ReadLine();

               Console.WriteLine("Digite El Correo: ");
                 string correo = Console.ReadLine();

            Persona persona = new Persona()
            {
                Id = id,
                Nombre = nombre,
                Telefono = telefono,
                Correo = correo
            };
            return persona;
            }

        }
    }
