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
                    command2.Parameters.AddWithValue("@Id_DetalleDocum", "1");
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
