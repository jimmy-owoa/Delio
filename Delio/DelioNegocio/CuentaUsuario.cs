using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelioNegocio
{
    public class CuentaUsuario
    {
        public string IdCuentaUsuario { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public int Telefono { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public int IdTipoCuenta { get; set; }
    }
}
