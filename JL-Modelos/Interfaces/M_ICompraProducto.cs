﻿using JL_Entidades;
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
        char obtnerIDCompra(int idTipoDoc);
    }
}
