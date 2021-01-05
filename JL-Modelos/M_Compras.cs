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
    public class M_Compras : M_ICompraProducto
    {
        BD_BaseDeDatos baseDeDatosC = new BD_BaseDeDatos();
        SqlConnection cnn = null;

        public M_Compras() {

            cnn = new SqlConnection(baseDeDatosC.cadenaConexion());

        }
        
        public bool devolucionCompra(int id_Compra)
        {
            throw new NotImplementedException();
        }

        public List<BD_Producto> getProductosLike(string productoD)
        {
            List<BD_Producto> productos = new List<BD_Producto>();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("listarProductosIngresos", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@descripicion", productoD);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    BD_Producto producto = null;
                    BD_Proveedor proveedor = null;
                    BD_Marca marca = null;
                    while (reader.Read())
                    {
                        producto = new BD_Producto();
                        marca = new BD_Marca();
                        proveedor = new BD_Proveedor();

                        producto.Id_Pro = int.Parse(reader["Id_Pro"].ToString());
                        producto.descripcion_larga = reader["Descripcion_Larga"].ToString();
                        marca.Marca = reader["Marca"].ToString();
                        producto.id_Marca = marca;
                        proveedor.nombre = reader["Proveedor"].ToString();
                        producto.idProvee = proveedor;
                        
                        productos.Add(producto);
                    }
                    cnn.Close();
                    return productos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                cnn.Close();
                productos = null;
                throw new Exception("M_Compras-getProductosLike+ " + ex.Message);
            }
        }

        public bool insertarCompra(BD_DocumentoCompras compras)
        {
            try
            {
                #region insertar Documento
                cnn.Open();
                SqlCommand command = new SqlCommand("insertarCompraProductos", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_DocComp",compras.id_DocComp);
                command.Parameters.AddWithValue("@IDProvee", compras.iDPROVEE.idProvee);
                command.Parameters.AddWithValue("@NroFac_Fisico",compras.nroFac_Fisico);
                command.Parameters.AddWithValue("@SubTotal_ingre",compras.subTotal_ingre);
                command.Parameters.AddWithValue("@Fecha_Ingre",DateTime.Now);
                command.Parameters.AddWithValue("@Total_Ingre",compras.total_Ingre);
                command.Parameters.AddWithValue("@id_Usu",compras.id_Usu.id_Usu);
                command.Parameters.AddWithValue("@ModalidadPago",compras.modalidadPago);
                command.Parameters.AddWithValue("@TiempoEspera",compras.tiempoEspera);
                command.Parameters.AddWithValue("@Fecha_Vencimiento",compras.fecha_Vencimiento);
                command.Parameters.AddWithValue("@Estado_Ingre",compras.estado_Ingre);
                command.Parameters.AddWithValue("@Recibiconforme",compras.recibiconforme);
                command.Parameters.AddWithValue("@Datos_Adicional",compras.datos_Adicional);
                command.Parameters.AddWithValue("@TipoDoc_Compra",compras.tipoDoc_Compra);

                command.ExecuteNonQuery();
                
               
                #endregion

                #region insertar El detalle 
                SqlCommand command2 = new SqlCommand("DetalleCompraProductos", cnn);
                command2.CommandType = CommandType.StoredProcedure;

                foreach (var producto in compras.productos)
                {
                    command2.Parameters.AddWithValue("@Id_DetalleDocum", "D"+compras.id_DocComp);
                    command2.Parameters.AddWithValue("@id_DocComp", compras.id_DocComp);
                    command2.Parameters.AddWithValue("@Id_Pro", producto.Id_Pro);
                    command2.Parameters.AddWithValue("@PrecioUnit", producto.pre_CompraS);
                    command2.Parameters.AddWithValue("@Cantidad",producto.cantidad);
                    command2.Parameters.AddWithValue("@Importe", (producto.pre_CompraS*producto.cantidad));

                    command2.ExecuteNonQuery();
                }

                cnn.Close();
                #endregion

                return true;

            }
            catch (Exception ex)
            {

                cnn.Close();
                throw new Exception("M_Compras-insertarCompra: " + ex.Message);
            }
        }

        public List<BD_DocumentoCompras> listarCompras()
        {
            List<BD_DocumentoCompras> compras = new List<BD_DocumentoCompras>();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("listarComprasProductos", cnn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    BD_DocumentoCompras compra = null;
                    while (reader.Read())
                    {
                        compra = new BD_DocumentoCompras();

                        compra.id_DocComp = reader["Id_DocComp"].ToString();
                        compra.iDPROVEE = new BD_Proveedor();
                        compra.iDPROVEE.nombre = reader["nombre"].ToString();
                        compra.echa_Ingre = DateTime.Parse(reader["Fecha_Ingre"].ToString());
                        compra.total_Ingre = decimal.Parse(reader["Total_Ingre"].ToString());
                        compra.tipoDoc_Compra = reader["TipoDoc_Compra"].ToString();
                        compra.modalidadPago = reader["ModalidadPago"].ToString();

                        compras.Add(compra);
                    }
                    cnn.Close();
                    return compras;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                cnn.Close();
                compras = null;
                throw new Exception("M_Compras-listarCompras+ " + ex.Message);
            }
        }

        public String obtnerIDCompra(int idTipoDoc)
        {
            try {

                cnn.Open();
                SqlCommand command = new SqlCommand("Sp_Actualiza_Tipo_Doc", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id_Tipo", 7);

                String idDocumento = command.ExecuteScalar().ToString();

                cnn.Close();
                return idDocumento;

            } catch (Exception ex) {

                cnn.Close();
                throw new Exception("M_Compras-obtnerIDCompra: " + ex.Message);
            }
        }
    }
}
