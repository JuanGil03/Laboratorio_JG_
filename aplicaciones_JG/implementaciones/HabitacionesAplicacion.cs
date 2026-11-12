using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using aplicaciones_JG.entidades;


namespace aplicaciones_JG.interfaces
{
        public class HabitacionesAplicacion : IHabitacionesAplicacion
        {
            private IConexion conexion;

            public HabitacionesAplicacion(IConexion conexion)
            {
                this.conexion = conexion;
            }

            public Habitaciones Actualizar(Habitaciones entidad)
            {
                // Hacer calculo o operaciones

                var entry = this.conexion!.Entry<Habitaciones>(entidad);
                entry.State = EntityState.Modified;
                this.conexion!.SaveChanges();
                return entidad;
            }

            public Habitaciones Borrar(Habitaciones entidad)
            {
                // Hacer calculo o operaciones

                this.conexion.Habitaciones!.Remove(entidad!);
                this.conexion.SaveChanges();
                return entidad;
            }

            public List<Habitaciones> Consultar()
            {
                return this.conexion.Habitaciones!
                    //.Include(x => x.Cliente)
                    .ToList();
            }

            public Habitaciones Insertar(Habitaciones entidad)
            {
                // Hacer calculo o operaciones

                this.conexion.Habitaciones!.Add(entidad!);
                this.conexion.SaveChanges();
                return entidad;
            }
        }
}
