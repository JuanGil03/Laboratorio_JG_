using System;
using System.Collections.Generic;
using System.Text;
using aplicaciones_JG.entidades;
using aplicaciones_JG.interfaces;
using presentaciones_JG.interfaces;

namespace aplicaciones_JG.implementaciones
{
    public class HabitacionesPresentacion : IHabitacionesPresentacion
    {
        private IComunicaciones IComunicaciones;

        public HabitacionesPresentacion(IComunicaciones IComunicaciones)
        {
            this.IComunicaciones = IComunicaciones;
        }

        public Habitaciones Actualizar(Habitaciones entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<Habitaciones>(
                "Habitaciones/Actualizar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public Habitaciones Borrar(Habitaciones entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            var task = this.IComunicaciones.Ejecutar<Habitaciones>(
                "Habitaciones/Borrar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<Habitaciones> Buscar(Habitaciones entidad)
        {
            var task = this.IComunicaciones.Ejecutar<List<Habitaciones>>(
                "Habitaciones/Buscar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<Habitaciones> Consultar()
        {
            var task = this.IComunicaciones.Ejecutar<List<Habitaciones>>(
                "Habitaciones/Consultar",
                null);
            task.Wait();
            return task.Result;
        }

        public Habitaciones Insertar(Habitaciones entidad)
        {
            if (entidad.Id != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<Habitaciones>(
                "Habitaciones/Insertar",
                entidad);
            task.Wait();
            return task.Result;
        }

        private bool Validar(Habitaciones entidad)
        {
            return string.IsNullOrEmpty(entidad.NumPersonas.ToString()) ||
                string.IsNullOrEmpty(entidad.Ubicacion) ||
                string.IsNullOrEmpty(entidad.PrecioNoche.ToString()) ||
                string.IsNullOrEmpty(entidad.TipoHabitacion);
        }
    }
}

