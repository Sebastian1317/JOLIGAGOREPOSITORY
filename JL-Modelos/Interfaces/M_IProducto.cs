using JL_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Modelos.Interfaces
{
   public interface M_IProducto
    {
        bool insertarProducto(BD_Producto producto);
        bool eliminarProducto(int? id_producto);
        bool actualizarProducto(BD_Producto producto);
        BD_Producto obtenerproducto(int id_Producto);
        List<BD_Producto> obtenerProductos();
        List<BD_Producto> obtenerProductosPor(String descripcion_l, String proveedor);
        List<BD_Categoria> listarCategoria();
        List<BD_Marca> listarMarca();

    }
}
