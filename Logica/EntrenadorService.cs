namespace Logica
{
    using Datos;
    using Entidades;
    using System;
    using System.Collections.Generic;

    public class EntrenadorService
    {
        readonly EntrenadorDao entrenadorDao;
        public EntrenadorService()
        {
            entrenadorDao = new EntrenadorDao();
        }
        public string SaveEntrenador(Entrenadores entrenador)
        {
            try
            {
                bool response = entrenadorDao.GetEntrenadorByIdentificacion(entrenador.Identificacion.Trim());
                if (response)
                {
                    return $"El Entrenador con identificacion {entrenador.Identificacion} ya se encuentra registrado";
                }
                entrenadorDao.SaveEntrenador(entrenador);
                return "Entrenador registrado con exito";
            }
            catch (Exception e)
            {
                return "Error" + e.Message;
            }
        }



        public List<Entrenadores> GetClientes()
        {
            try
            {
                return entrenadorDao.GetEntrenadores();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Entrenadores GetEntrenadorById(int id)
        {
            try
            {

                Entrenadores entrenador = entrenadorDao.GetEntrenadorById(id);
                return entrenador;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string UpdateEntrenador(Entrenadores entrenador)
        {

            try
            {
                entrenadorDao.UpdateEntrenador(entrenador);
                return "Entrenador modificado con exito";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }
    }
}