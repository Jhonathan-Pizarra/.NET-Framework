﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infra.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StayHubEntities : DbContext
    {
        public StayHubEntities()
            : base("name=StayHubEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cabecera_reserva> cabecera_reserva { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<detalle_reserva> detalle_reserva { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<habitacion> habitacion { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
