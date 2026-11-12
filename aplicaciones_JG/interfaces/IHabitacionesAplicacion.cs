using aplicaciones_JG.entidades;

namespace aplicaciones_JG.interfaces
{
    public interface IHabitacionesAplicacion
    {
        Habitaciones Insertar(Habitaciones entidad);
        List<Habitaciones> Consultar();
        Habitaciones Actualizar(Habitaciones entidad);
        Habitaciones Borrar(Habitaciones entidad);
    }
}
