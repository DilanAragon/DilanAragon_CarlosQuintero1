using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICrudArchivos<T>
    {
        bool Update(List<T> registros);
        List<T> GetAll();
        T Mapper(string linea);

    }
}
