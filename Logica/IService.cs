using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IServices<T>
    {
        /// <summary>
        /// Metodo para agregar contactos
        /// </summary>
        string Save(T registro);
        string Delete(T registro);
        string Edit(T oldRegistro, T UpdateRegistro);
        List<T> GetAll();
        T GetById(int id);
        T GetByPhone(string phone);
        bool Exist(T registro);

    }
}
