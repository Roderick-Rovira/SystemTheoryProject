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
    
    public partial class Sp_Listar_ReporteCierreCajas_Result
    {
        public int Id_RprtCierreCajas { get; set; }
        public System.DateTime Fecha_cierre { get; set; }
        public decimal Total_Ventas_Contado { get; set; }
        public decimal Total_Ventas_Credito { get; set; }
        public decimal Total_Devoluciones { get; set; }
        public decimal Total_Efectivo { get; set; }
        public decimal Total_Tarjeta { get; set; }
        public decimal Total_Merma { get; set; }
        public decimal Total_General { get; set; }
    }
}
