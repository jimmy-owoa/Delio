//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DelioDALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Oferta
    {
        public int idOferta { get; set; }
        public Nullable<double> porcentajeDescuento { get; set; }
        public Nullable<System.DateTime> fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaTermino { get; set; }
        public Nullable<bool> loQuiero { get; set; }
        public Nullable<int> idCuentaUsuarioFK { get; set; }
        public Nullable<int> idCuentaProductoFK { get; set; }
    
        public virtual CuentaUsuario CuentaUsuario { get; set; }
        public virtual Producto Producto { get; set; }
    }
}