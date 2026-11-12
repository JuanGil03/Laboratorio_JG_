
using aplicaciones_JG.entidades;

namespace aplicaciones_JG.interfaces
{
    public interface IHabitacionesPresentacion
    {
        Habitaciones Insertar(Habitaciones entidad);
        Habitaciones Actualizar(Habitaciones entidad);
        List<Habitaciones> Consultar();
        List<Habitaciones> Buscar(Habitaciones entidad);
        Habitaciones Borrar(Habitaciones entidad);
    }
}
