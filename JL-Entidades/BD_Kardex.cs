using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Entidades
{
   public class BD_Kardex
    {

        public int id_krdx { get; set; }
        public int item { get; set; }
        public DateTime fecha_Krdx { get; set; }
        public String doc_Soporte { get; set; }
        public String det_Operacion { get; set; }
        public decimal cantidad_In { get; set; }
        public decimal precio_In { get; set; }
        public decimal total_In { get; set; }
        public decimal cantidad_Out { get; set; }
        public decimal precio_Out { get; set; }
        public decimal total_Out { get; set; }
        public decimal cantidad_Saldo { get; set; }
        public decimal promedio { get; set; }

        public BD_Kardex()
        {
        }

        public BD_Kardex(int id_krdx, int item, DateTime fecha_Krdx, string doc_Soporte, string det_Operacion, decimal cantidad_In, decimal precio_In, decimal total_In, decimal cantidad_Out, decimal precio_Out, 
            decimal total_Out, decimal cantidad_Saldo, decimal promedio)
        {
            this.id_krdx = id_krdx;
            this.item = item;
            this.fecha_Krdx = fecha_Krdx;
            this.doc_Soporte = doc_Soporte;
            this.det_Operacion = det_Operacion;
            this.cantidad_In = cantidad_In;
            this.precio_In = precio_In;
            this.total_In = total_In;
            this.cantidad_Out = cantidad_Out;
            this.precio_Out = precio_Out;
            this.total_Out = total_Out;
            this.cantidad_Saldo = cantidad_Saldo;
            this.promedio = promedio;
        }
    }
}
