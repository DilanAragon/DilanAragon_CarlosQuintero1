using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EntrenadorService
    {
        EntrenadorDao entrenadorDao;
        public EntrenadorService()
        {
            entrenadorDao = new EntrenadorDao();
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
    }
}
