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
    public class M_Proveedor : M_IProveedor
    {
        BD_BaseDeDatos baseDeDatosC = new BD_BaseDeDatos();
        SqlConnection cnn = null;

        public M_Proveedor() {

            cnn = new SqlConnection(baseDeDatosC.cadenaConexion());
        }


        public bool actualizarProveedor(BD_Proveedor usuario)
        {
            try
            {

                cnn.Open();
                SqlCommand command = new SqlCommand("actualizarProveedor", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IDPROVEE", usuario.nombre);
                command.Parameters.AddWithValue("@NOMBRE", usuario.nombre);
                command.Parameters.AddWithValue("@DIRECCION", usuario.direccion);
                command.Parameters.AddWithValue("@TELEFONO", usuario.telefono);
                command.Parameters.AddWithValue("@RUBRO", usuario.rubro);
                command.Parameters.AddWithValue("@RFC", usuario.rfc);
                command.Parameters.AddWithValue("@CORREO", usuario.correo);
                command.Parameters.AddWithValue("@CONTACTO", usuario.contacto);
                command.Parameters.AddWithValue("@FOTO_LOGO", usuario.foto_logo);
                command.Parameters.AddWithValue("@ESTADO_PROVDR", usuario.estado_provdr);

                command.ExecuteNonQuery();



                cnn.Close();

                return true;

            }
            catch (Exception ex)
            {

                cnn.Close();
                throw new Exception("M_Proveedor-actualizarProveedor: " + ex.Message);
            }
        }

        public bool eliminarProveedor(int? id_proveedor)
        {
            try
            {

                cnn.Open();
                SqlCommand command = new SqlCommand("eliminarProveedor", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IDPROVEE", id_proveedor);
                
                command.ExecuteNonQuery();
                
                cnn.Close();

                return true;

            }
            catch (Exception ex)
            {

                cnn.Close();
                throw new Exception("M_Proveedor-eliminarProveedor: " + ex.Message);
            }
        }

        public bool insertarProveedor(BD_Proveedor usuario)
        {
            try
            {

                cnn.Open();
                SqlCommand command = new SqlCommand("insertarProveedor", cnn);
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@NOMBRE", usuario.nombre);
                command.Parameters.AddWithValue("@DIRECCION", usuario.direccion);
                command.Parameters.AddWithValue("@TELEFONO", usuario.telefono);
                command.Parameters.AddWithValue("@RUBRO", usuario.rubro);
                command.Parameters.AddWithValue("@RFC", usuario.rfc);
                command.Parameters.AddWithValue("@CORREO", usuario.correo);
                command.Parameters.AddWithValue("@CONTACTO", usuario.contacto);
                command.Parameters.AddWithValue("@FOTO_LOGO", usuario.foto_logo);
                command.Parameters.AddWithValue("@ESTADO_PROVDR", usuario.estado_provdr);

                command.ExecuteNonQuery();



                cnn.Close();

                return true;

            }
            catch (Exception ex)
            {

                cnn.Close();
                throw new Exception("M_Proveedor-insertarProveedor: " + ex.Message);
            }
        }

        public List<BD_Proveedor> obtenerProveedores()
        {
            List<BD_Proveedor> proveedores = new List<BD_Proveedor>(); 
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("seleccionarProveedores", cnn);
                command.CommandType = CommandType.StoredProcedure;
                
                SqlDataReader reader = command.ExecuteReader();

               
                if (reader.HasRows) {

                    
                    while (reader.Read()) {
                        BD_Proveedor proveedor = new BD_Proveedor();

                        proveedor.idProvee = int.Parse(reader["IDPROVEE"].ToString());
                        proveedor.nombre = reader["NOMBRE"].ToString();
                        proveedor.direccion = reader["DIRECCION"].ToString();
                        proveedor.telefono = reader["TELEFONO"].ToString();
                        proveedor.rfc = reader["RFC"].ToString();
                        proveedor.correo = reader["CORREO"].ToString();
                        proveedor.contacto = reader["CONTACTO"].ToString();

                        proveedores.Add(proveedor);
                    }
                    cnn.Close();
                    return proveedores;

                }
                else {

                    return null;

                }
                
            }
            catch (Exception ex)
            {
                cnn.Close();
                proveedores = null;
                throw new Exception("CN_Proveedor-obtenerProveedores+ " + ex.Message);
            }
        }

        public List<BD_Proveedor> obtenerProveedorPor(string nombre, string correo, string rfc)
        {
            List<BD_Proveedor> proveedores = new List<BD_Proveedor>();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("seleccionarProveedoresPor", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@RFC", rfc);
                command.Parameters.AddWithValue("@NOMBRE", nombre);
                command.Parameters.AddWithValue("@CORREO", correo);
                
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    
                    BD_Proveedor proveedor = new BD_Proveedor();
                    while (reader.Read())
                    {
                       
                        proveedor.idProvee = int.Parse(reader["IDPROVEE"].ToString());
                        proveedor.nombre = reader["NOMBRE"].ToString();
                        proveedor.direccion = reader["DIRECCION"].ToString();
                        proveedor.telefono = reader["TELEFONO"].ToString();
                        proveedor.rfc = reader["RFC"].ToString();
                        proveedor.correo = reader["CORREO"].ToString();
                        proveedor.contacto = reader["CONTACTO"].ToString();

                        proveedores.Add(proveedor);
                        proveedor = new BD_Proveedor();
                    }
                    cnn.Close();
                    return proveedores;

                }
                else
                {
                    return null;

                }

            }
            catch (Exception ex)
            {
                cnn.Close();
                proveedores = null;
                throw new Exception("CN_Proveedor-obtenerProveedorPor+ " + ex.Message);
            }
        }
    }
}
