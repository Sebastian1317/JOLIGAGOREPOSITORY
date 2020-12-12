using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Entidades
{
    public class BD_DocumentoCompras
    {
        public String id_DocComp { get; set; }
        public char nroFac_Fisico { get; set; }
        public BD_Proveedor iDPROVEE { get; set; }
        public decimal subTotal_ingre { get; set; }
        public DateTime echa_Ingre { get; set; }
        public decimal total_Ingre { get; set; }
        public BD_Usuario id_Usu { get; set; }
        public String modalidadPago { get; set; }
        public int tiempoEspera { get; set; }
        public DateTime fecha_Vencimiento { get; set; }
        public String estado_Ingre { get; set; }
        public bool recibiconforme { get; set; }
        public String datos_Adicional { get; set; }
        public String tipoDoc_Compra { get; set; }
        public List<BD_Producto> productos { get; set; }
     

        public BD_DocumentoCompras()
        {
        }

        public BD_DocumentoCompras(String id_DocComp, char nroFac_Fisico,
            BD_Proveedor iDPROVEE, decimal subTotal_ingre, DateTime echa_Ingre,
            decimal total_Ingre, BD_Usuario id_Usu, string modalidadPago, 
            int tiempoEspera, DateTime fecha_Vencimiento, string estado_Ingre, bool recibiconforme, string datos_Adicional, 
            string tipoDoc_Compra, List<BD_Producto> productos)
        {
            this.id_DocComp = id_DocComp;
            this.nroFac_Fisico = nroFac_Fisico;
            this.iDPROVEE = iDPROVEE;
            this.subTotal_ingre = subTotal_ingre;
            this.echa_Ingre = echa_Ingre;
            this.total_Ingre = total_Ingre;
            this.id_Usu = id_Usu;
            this.modalidadPago = modalidadPago;
            this.tiempoEspera = tiempoEspera;
            this.fecha_Vencimiento = fecha_Vencimiento;
            this.estado_Ingre = estado_Ingre;
            this.recibiconforme = recibiconforme;
            this.datos_Adicional = datos_Adicional;
            this.tipoDoc_Compra = tipoDoc_Compra;
            this.productos = productos;
            
        }

    }
}
