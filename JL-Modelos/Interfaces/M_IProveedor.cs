using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JL_Entidades;

namespace JL_Modelos.Interfaces
{
   public interface M_IProveedor
    {
        bool insertarProveedor(BD_Proveedor usuario);
        bool eliminarProveedor(int? id_proveedor);
        bool actualizarProveedor(BD_Proveedor usuario);
        List<BD_Proveedor> obtenerProveedores();
        List<BD_Proveedor> obtenerProveedorPor(String nombre, String correo,String rfc);
        
    }
}
