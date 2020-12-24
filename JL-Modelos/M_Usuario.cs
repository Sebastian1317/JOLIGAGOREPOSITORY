using JL_Entidades;
using JL_Modelos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Modelos
{
    public class M_Usuario : M_IUsuario
    {
        BD_BaseDeDatos baseDeDatosC = new BD_BaseDeDatos();
        SqlConnection cnn = null;

        public M_Usuario()
        {

            cnn = new SqlConnection(baseDeDatosC.cadenaConexion());

        }
        
        public BD_Usuario accesarLogin(string correo, string contraseña)
        {
            BD_Usuario usuarioB = new BD_Usuario();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("ingresarLogin", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@contraseña", contraseña);

                SqlDataReader reader = command.ExecuteReader();

                BD_Rol roles = new BD_Rol();

                while (reader.Read())
                {
                    usuarioB.id_Usu= int.Parse(reader["Id_Usu"].ToString());
                    usuarioB.nombres = reader["Nombre"].ToString();
                    roles.Id_Rol = int.Parse(reader["Id_Rol"].ToString());
                    roles.Rol = reader["Rol"].ToString();
                    usuarioB.id_Rol = roles;
                    usuarioB.ubicacion_Foto = (String)reader["Ubicacion_Foto"];

                }

                return usuarioB;

            }
            catch (Exception ex)
            {
                cnn.Close();
                usuarioB= null;
                throw new Exception("CN_Usuario-accesarLogin+ " + ex.Message);

            }
        }

        public bool actualizarUsuario(BD_Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool eliminarUsuario(int id_usuario)
        {
            throw new NotImplementedException();
        }

        public bool insertarUsuario(BD_Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public List<BD_Usuario> obtenerUsuarios()
        {
            throw new NotImplementedException();
        }

        public List<BD_Usuario> obtenerUsuariosPor(string usuario, string nombre, string correo)
        {
            throw new NotImplementedException();
        }
    }
}
