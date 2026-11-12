using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using aplicaciones_JG.entidades;
using aplicaciones_JG.interfaces;

namespace aplicaciones_JG.implementaciones
{
        public class Conexion : DbContext, IConexion
        {
            public string? StringConexion { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }

            public DbSet<Habitaciones>? Habitaciones { get; set; }
        }
    }
