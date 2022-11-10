﻿using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioRegistroEntrenadores : IServices<Entrenadores>
    {
        List<Entrenadores> entrenadoresl;
        readonly RepositorioRegistroEntrenadores repositorioRegistroEntrenadores;
        public ServicioRegistroEntrenadores()
        {
            repositorioRegistroEntrenadores = new RepositorioRegistroEntrenadores("Entrenadores.dat");
            entrenadoresl = new List<Entrenadores>();
        }
        public string Delete(Entrenadores registro)
        {
            //validar
            entrenadoresl.Remove(registro);
            repositorioRegistroEntrenadores.Update(entrenadoresl);
            Refresh();
            return $"el Registro se elimino correctamente con el nombre {registro.Nombre}";
        }
        void Refresh()
        {
            entrenadoresl = repositorioRegistroEntrenadores.GetAll();
        }
        public string Edit(Entrenadores oldRegistro, Entrenadores UpdateRegistro)
        {
            oldRegistro.Id = UpdateRegistro.Id;
            oldRegistro.CodigoEntrenador = UpdateRegistro.CodigoEntrenador;
            oldRegistro.Nombre = UpdateRegistro.Nombre;
            oldRegistro.Telefono = UpdateRegistro.Telefono;
            oldRegistro.Correo = UpdateRegistro.Correo;

            var estado = repositorioRegistroEntrenadores.Update(entrenadoresl);
            Refresh();

            return estado ? $"se actulizo el Registro {UpdateRegistro.Nombre}" :
                $"ERROR al actulizar el Registro {UpdateRegistro.Nombre}";
        }

        public bool Exist(Entrenadores registro)
        {
            throw new NotImplementedException();
        }

        public List<Entrenadores> GetAll()
        {
            return entrenadoresl;
        }

        public Entrenadores GetById(string id)
        {
            foreach (var item in entrenadoresl)
            {
                if ( item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public Entrenadores GetByPhone(string phone)
        {
            foreach (var item in entrenadoresl)
            {
                if (item.Telefono == phone)
                {
                    return item;
                }
            }
            return null;
        }

        public string Save(Entrenadores registro)
        {


            if (GetByPhone(registro.Telefono) != null)
            {
                return $"el Registro ya existe con este numero de telefono {registro.Telefono}";
            }
            var estado = repositorioRegistroEntrenadores.Guardar(registro);

            Refresh();

            return estado ? $"el Registro se agrego correctamente con el nombre {registro.Nombre}" :
                                 $"ERROR al Guardar el Registro con el nombre {registro.Nombre}";
        }
    }
}
