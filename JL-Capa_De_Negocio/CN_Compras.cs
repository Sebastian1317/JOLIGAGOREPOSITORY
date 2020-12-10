using JL_Entidades;
using JL_Modelos;
using JL_Modelos.Interfaces;
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



    }
}
