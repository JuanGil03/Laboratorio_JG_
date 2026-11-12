using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using aplicaciones_JG.entidades;


namespace aplicaciones_JG.interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }
        DbSet<Habitaciones>? Habitaciones { get; set; }
        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
