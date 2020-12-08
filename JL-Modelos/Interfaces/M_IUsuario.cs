using JL_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Modelos.Interfaces
{
  public interface M_IUsuario
    {
        bool insertarUsuario(BD_Usuario usuario);
        bool eliminarUsuario(int id_usuario);
        bool actualizarUsuario(BD_Usuario usuario);
        List<BD_Usuario> obtenerUsuarios();
        BD_Usuario accesarLogin(String correo, String contraseña);
        List<BD_Usuario> obtenerUsuariosPor(String usuario, String nombre, String correo);

    }
}
