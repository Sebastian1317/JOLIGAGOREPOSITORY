using JL_Entidades;
using JL_Modelos;
using JL_Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JL_Capa_De_Negocio
{
    public class CN_Usuario 
    {

        M_Usuario iusuario = new M_Usuario();

        public BD_Usuario accesarLoginC(String correo,String contraseña) {



            BD_Usuario usuarioC = new BD_Usuario();
            ValidacionesRegex validaremail = new ValidacionesRegex();

            try {

                if (validaremail.validarEmail(correo)==true) {

                    usuarioC = iusuario.accesarLogin(correo: correo, contraseña: contraseña);

                    if (usuarioC == null)
                    {

                        usuarioC = null;
                    }
                    else {

                        usuarioC = null;
                    }
                }
                return usuarioC;
            }
            catch (Exception ex) {

                MessageBox.Show("+CN-Usuario-accesarLogin: " + ex.Message);
                return usuarioC = null;
               
            }
        }

    }
}
