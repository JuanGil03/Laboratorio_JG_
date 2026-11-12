using System;
using System.Collections.Generic;
using System.Text;

namespace presentaciones_JG.interfaces
{
    public interface IComunicaciones
    {
        Task<T> Ejecutar<T>(string url, object entidad);
    }
}
