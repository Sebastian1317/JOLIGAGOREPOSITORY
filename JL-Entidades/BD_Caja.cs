using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Entidades
{
  public class BD_Caja
    {

        public int IdCaja { get; set; }

        public DateTime Fecha_Caja { get; set; }
        public String Tipo_Caja { get; set; }

        public String Concepto { get; set; }

        public String De_Para { get; set; }

        public Char Nro_Doc { get; set; }

        public Decimal ImporteCaja { get; set; }

        public int Id_Usu { get; set; }

        public Decimal TotalUti { get; set; }

        public String TipoPago { get; set; }

        public String GeneradoPor { get; set;}

        public String EstadoCaja { get; set; }




        public BD_Caja()
        {
        }

        public BD_Caja(int idCaja, DateTime fecha_Caja, string tipo_Caja, string concepto, string de_Para, char nro_Doc, 
            decimal importeCaja, int id_Usu, decimal totalUti, string tipoPago, string generadoPor, string estadoCaja)
        {
            IdCaja = idCaja;
            Fecha_Caja = fecha_Caja;
            Tipo_Caja = tipo_Caja;
            Concepto = concepto;
            De_Para = de_Para;
            Nro_Doc = nro_Doc;
            ImporteCaja = importeCaja;
            Id_Usu = id_Usu;
            TotalUti = totalUti;
            TipoPago = tipoPago;
            GeneradoPor = generadoPor;
            EstadoCaja = estadoCaja;
        }
    }
}
