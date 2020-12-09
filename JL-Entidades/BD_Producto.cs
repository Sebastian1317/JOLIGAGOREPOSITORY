using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Entidades
{
    public class BD_Producto
    {
     public int Id_Pro { get; set; }
     public BD_Proveedor idProvee { get; set; }
        public String descripcion_larga { get; set; }
        public decimal frank { get; set; }
        public decimal pre_CompraS { get; set; }
        public decimal pre_CompraD { get; set; }
        public decimal stock_Actual { get; set; }
        public BD_Categoria id_Cat { get; set; }
        public BD_Marca id_Marca { get; set; }
        public String foto { get; set; }
        public decimal pre_vntaxMenor { get; set; }
        public decimal pre_vntaxMayor { get; set; }
        public decimal pre_Vntadolar { get; set; }
        public char undMedida { get; set; }
        public decimal pesoUnit { get; set; }
        public decimal utilidadUnit { get; set; }
        public String tipoProdcto { get; set; }
        public decimal valor_porCant { get; set; }
        public String estado_Pro { get; set; }
        public String id_ProductoFact { get; set; }
        public String claveProducto { get; set; }

        public BD_Producto()
        {
        }

        public BD_Producto(int id_Pro, BD_Proveedor idProvee, string descripcion_larga, 
            decimal frank, decimal pre_CompraS, decimal pre_CompraD, decimal stock_Actual, BD_Categoria id_Cat, 
            BD_Marca id_Marca, string foto, decimal pre_vntaxMenor, decimal pre_vntaxMayor, decimal pre_Vntadolar, 
            char undMedida, decimal pesoUnit, decimal utilidadUnit, string tipoProdcto, 
            decimal valor_porCant, string estado_Pro, string id_ProductoFact, string claveProducto)
        {
            Id_Pro = id_Pro;
            this.idProvee = idProvee;
            this.descripcion_larga = descripcion_larga;
            this.frank = frank;
            this.pre_CompraS = pre_CompraS;
            this.pre_CompraD = pre_CompraD;
            this.stock_Actual = stock_Actual;
            this.id_Cat = id_Cat;
            this.id_Marca = id_Marca;
            this.foto = foto;
            this.pre_vntaxMenor = pre_vntaxMenor;
            this.pre_vntaxMayor = pre_vntaxMayor;
            this.pre_Vntadolar = pre_Vntadolar;
            this.undMedida = undMedida;
            this.pesoUnit = pesoUnit;
            this.utilidadUnit = utilidadUnit;
            this.tipoProdcto = tipoProdcto;
            this.valor_porCant = valor_porCant;
            this.estado_Pro = estado_Pro;
            this.id_ProductoFact = id_ProductoFact;
            this.claveProducto = claveProducto;
        }
    }
}
