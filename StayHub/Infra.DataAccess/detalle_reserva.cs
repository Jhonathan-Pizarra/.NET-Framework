//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class detalle_reserva
    {
        public int id_detalle { get; set; }
        public Nullable<int> id_reserva { get; set; }
        public Nullable<int> id_habitacion { get; set; }
        public Nullable<int> cantidad_personas { get; set; }
        public Nullable<int> cantidad_dias { get; set; }
        public string observaciones { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual cabecera_reserva cabecera_reserva { get; set; }
        public virtual habitacion habitacion { get; set; }
    }
}
