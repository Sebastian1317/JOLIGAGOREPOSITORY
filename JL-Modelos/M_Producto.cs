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
    public class M_Producto : M_IProducto
    {
        BD_BaseDeDatos baseDeDatosC = new BD_BaseDeDatos();
        SqlConnection cnn = null;

        public M_Producto()
        {
            cnn = new SqlConnection(baseDeDatosC.cadenaConexion());
        }

        public bool actualizarProducto(BD_Producto producto)
        {
            try
            {

                cnn.Open();
                SqlCommand command = new SqlCommand("actualizarProducto", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_Pro",producto.Id_Pro);
                command.Parameters.AddWithValue("@IDPROVEE",producto.idProvee);
                command.Parameters.AddWithValue("@Descripcion_Larga", producto.descripcion_larga);
                command.Parameters.AddWithValue("@Frank", producto.frank);
                command.Parameters.AddWithValue("@Pre_CompraS", producto.pre_CompraS);
                command.Parameters.AddWithValue("@Pre_Compra$", producto.pre_CompraD);
                command.Parameters.AddWithValue("@Stock_Actual",producto.stock_Actual);
                command.Parameters.AddWithValue("@Id_Cat",producto.id_Cat);
                command.Parameters.AddWithValue("@Id_Marca", producto.id_Marca);
                command.Parameters.AddWithValue("@Foto", producto.foto);
                command.Parameters.AddWithValue("@Pre_vntaxMenor", producto.pre_vntaxMenor);
                command.Parameters.AddWithValue("@Pre_vntaxMayor", producto.pre_vntaxMayor);
                command.Parameters.AddWithValue("@Pre_Vntadolar", producto.pre_Vntadolar);
                command.Parameters.AddWithValue("@UndMedida", producto.undMedida);
                command.Parameters.AddWithValue("@PesoUnit", producto.pesoUnit);
                command.Parameters.AddWithValue("@UtilidadUnit", producto.utilidadUnit);
                command.Parameters.AddWithValue("@TipoProdcto", producto.tipoProdcto);
                command.Parameters.AddWithValue("@Valor_porCant", producto.valor_porCant);
                command.Parameters.AddWithValue("@Estado_Pro", producto.estado_Pro);               
                command.Parameters.AddWithValue("@ClaveProducto", producto.claveProducto);

                command.ExecuteNonQuery();



                cnn.Close();

                return true;

            }
            catch (Exception ex)
            {

                cnn.Close();
                throw new Exception("M_Producto-actualizarProducto: " + ex.Message);
            }
        }

        public bool eliminarProducto(int? id_producto)
        {
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("eliminarProducto", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_Pro", id_producto);

                command.ExecuteNonQuery();

                cnn.Close();

                return true;

            }
            catch (Exception ex)
            {

                cnn.Close();
                throw new Exception("M_Producto-eliminarProducto: " + ex.Message);
            }
        }

        public bool insertarProducto(BD_Producto producto)
        {
            try
            {

                cnn.Open();
                SqlCommand command = new SqlCommand("insertarProducto", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_Pro", producto.Id_Pro);
                command.Parameters.AddWithValue("@IDPROVEE", producto.idProvee);
                command.Parameters.AddWithValue("@Descripcion_Larga", producto.descripcion_larga);
                command.Parameters.AddWithValue("@Frank", producto.frank);
                command.Parameters.AddWithValue("@Pre_CompraS", producto.pre_CompraS);
                command.Parameters.AddWithValue("@Pre_Compra$", producto.pre_CompraD);
                command.Parameters.AddWithValue("@Stock_Actual", producto.stock_Actual);
                command.Parameters.AddWithValue("@Id_Cat", producto.id_Cat);
                command.Parameters.AddWithValue("@Id_Marca", producto.id_Marca);
                command.Parameters.AddWithValue("@Foto", producto.foto);
                command.Parameters.AddWithValue("@Pre_vntaxMenor", producto.pre_vntaxMenor);
                command.Parameters.AddWithValue("@Pre_vntaxMayor", producto.pre_vntaxMayor);
                command.Parameters.AddWithValue("@Pre_Vntadolar", producto.pre_Vntadolar);
                command.Parameters.AddWithValue("@UndMedida", producto.undMedida);
                command.Parameters.AddWithValue("@PesoUnit", producto.pesoUnit);
                command.Parameters.AddWithValue("@UtilidadUnit", producto.utilidadUnit);
                command.Parameters.AddWithValue("@TipoProdcto", producto.tipoProdcto);
                command.Parameters.AddWithValue("@Valor_porCant", producto.valor_porCant);
                command.Parameters.AddWithValue("@Estado_Pro", producto.estado_Pro);
                command.Parameters.AddWithValue("@id_ProductoFact", producto.id_ProductoFact);
                command.Parameters.AddWithValue("@ClaveProducto", producto.claveProducto);

                command.ExecuteNonQuery();



                cnn.Close();

                return true;

            }
            catch (Exception ex)
            {

                cnn.Close();
                throw new Exception("M_Producto-insertarProducto: " + ex.Message);
            }
        }

        public List<BD_Categoria> listarCategoria()
        {
            List<BD_Categoria> categorias = new List<BD_Categoria>();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("seleccionarCategoria", cnn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    BD_Categoria categoria = null;
                    while (reader.Read())
                    {
                        categoria = new BD_Categoria();


                        categorias.Add(categoria);
                    }
                    cnn.Close();
                    return categorias;

                }
                else
                {

                    return null;

                }

            }
            catch (Exception ex)
            {
                cnn.Close();
                categorias = null;
                throw new Exception("CN_Productos-listarCategoria+ " + ex.Message);
            }
        }

        public List<BD_Marca> listarMarca()
        {
            List<BD_Marca> marcas = new List<BD_Marca>();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("seleccionarMarca", cnn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    BD_Marca marca = null;
                    while (reader.Read())
                    {
                        marca = new BD_Marca();


                        marcas.Add(marca);
                    }
                    cnn.Close();
                    return marcas;

                }
                else
                {

                    return null;

                }

            }
            catch (Exception ex)
            {
                cnn.Close();
                marcas = null;
                throw new Exception("CN_Productos-listarMarca+ " + ex.Message);
            }
        }

        public List<BD_Producto> obtenerProductos()
        {
            throw new NotImplementedException();
        }

        public List<BD_Producto> obtenerProductosPor(string descripcion_l, string proveedor)
        {
            throw new NotImplementedException();
        }
    }
}
