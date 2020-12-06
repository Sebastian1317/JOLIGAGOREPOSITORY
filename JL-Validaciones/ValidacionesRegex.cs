using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JL_Validaciones
{
    public class ValidacionesRegex
    {
        public bool validarEmail(String email) {

            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {

                return true;
            }
            else {
                return false;
            }
        }

    }
}
