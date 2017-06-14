using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelioDALC;
using System.Data.Entity;

namespace DelioConexion
{
    public class CommonBC
    {
        private static Delio_INSEntities modeloDelio;

        public static Delio_INSEntities ModeloDelio
        {
            get
            {
                if (modeloDelio == null)
                {
                    modeloDelio = new Delio_INSEntities();
                }
                return modeloDelio;
            }
        }

        public CommonBC()
        {

        }
    }
}
