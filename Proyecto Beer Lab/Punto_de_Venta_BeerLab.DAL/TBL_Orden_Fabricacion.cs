//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Punto_de_Venta_BeerLab.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_Orden_Fabricacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Orden_Fabricacion()
        {
            this.TBL_Detalle_Orden_Fabricacion = new HashSet<TBL_Detalle_Orden_Fabricacion>();
        }
    
        public int Id_Orden { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public Nullable<System.DateTime> FechaFabricacion { get; set; }
        public Nullable<int> Id_estado { get; set; }
        public Nullable<int> Id_factura { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Detalle_Orden_Fabricacion> TBL_Detalle_Orden_Fabricacion { get; set; }
        public virtual TBL_Estado TBL_Estado { get; set; }
        public virtual TBL_Factura TBL_Factura { get; set; }
    }
}