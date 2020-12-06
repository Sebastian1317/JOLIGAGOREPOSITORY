using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Modelos
{
   public class BD_BaseDeDatos
    {

        public String cadenaConexion()
        {

            return "Data Source=.;Initial Catalog=POS_Microsell_Lite;User ID=sa;Password=1234;";
        }

    }
}
