using JL_Entidades;
using JL_Modelos;
using JL_Modelos.Interfaces;
using JL_Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JL_Capa_De_Negocio
{
  public class CN_Compras
    {

        private M_ICompraProducto icompra = new M_Compras();

        public bool insertarCompra(BD_DocumentoCompras compras) {
            try {

                string idgenerate = obtnerIDCompra();
                if (idgenerate != null)
                    compras.id_DocComp = idgenerate;
                return icompra.insertarCompra(compras);
            } catch (Exception ex) {

                MessageBox.Show("+CN_Compras-inertarCompra: "+ex.Message);
                return false;
            }

        }

        public bool devolucionCompra(int id_Compra) {
            
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("+CN_Compras-devolucionCompra: " + ex.Message);
                return false;
            }
        }

        private String obtnerIDCompra() {
            try
            {
                return icompra.obtnerIDCompra(7);
            }
            catch (Exception ex)
            {
                MessageBox.Show("+CN_Compras-obtnerIDCompra: " + ex.Message);
                return null;
            }

        }

        public void listarCompras(DataGridView dataGridView)
        {
            try
            {

                //String[] cabeceras = new String[6];
                //cabeceras[0] = "Num. Compra";
                //cabeceras[1] = "Proveedor";
                //cabeceras[2] = "Fecha de registro";
                //cabeceras[3] = "Total de ingresos";
                //cabeceras[4] = "Tipo de compra";
                //cabeceras[5] = "Modalidad de pago";

                //foreach (var cabecera in cabeceras)
                //{
                //    dataGridView.Columns.Add(cabecera, cabecera);
                //}

                foreach (var item in icompra.listarCompras())
                {
                    dataGridView.Rows.Add(item.id_DocComp.ToString(), 
                        item.iDPROVEE.nombre,item.echa_Ingre.ToString(),
                        item.total_Ingre.ToString(),item.tipoDoc_Compra.ToString(),
                        item.modalidadPago.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("+CN_Compras-listarCompras: "+ex.Message);
            }
        }
    }
}
