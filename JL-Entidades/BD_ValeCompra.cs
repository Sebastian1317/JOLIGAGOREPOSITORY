using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Entidades
{
   public class BD_ValeCompra
    {
        public int IdVale { get; set; }

        public int Id_Cliente { get; set; }
        public Char NroDoc { get; set; }

        public Decimal ImporteVale { get; set; }

        public String DetalleVale { get; set; }

        public String EstadoVale { get; set; }


        public BD_ValeCompra()
        {
        }

        public BD_ValeCompra(int Idvale, int Id_cliente, Char Nrodoc, Decimal importevale, String detallevale,  String estadovale)
        {
            this.IdVale = Idvale;
            this.Id_Cliente=Id_cliente;
            this.NroDoc = Nrodoc;
            this.ImporteVale = importevale;
            this.DetalleVale = detallevale;
            this.EstadoVale = estadovale;
        }

    }
}
