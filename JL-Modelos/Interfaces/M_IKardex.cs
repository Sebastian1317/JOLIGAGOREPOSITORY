using JL_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Modelos.Interfaces
{
    public interface M_IKardex
    {
        bool insertarKardex(BD_Kardex kardex,int idProvee,int idPro);
        bool actualizarDetalleKardeKardex(BD_Kardex kardex);
        

    }
}
