using JL_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Modelos.Interfaces
{
   public interface M_ICompraProducto
    {
        bool insertarCompra(BD_DocumentoCompras compras);
        bool devolucionCompra(int id_Compra);
        String obtnerIDCompra(int idTipoDoc);
        List<BD_DocumentoCompras> listarCompras();
        List<BD_Producto> getProductosLike(String producto);


    }
}
