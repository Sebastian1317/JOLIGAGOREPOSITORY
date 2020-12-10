using JL_Entidades;
using JL_Modelos;
using JL_Modelos.Interfaces;
using JL_Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JL_Capa_De_Negocio
{
    public class CN_Producto
    {
        private M_IProducto iproducto = new M_Producto();

        public bool insertarProducto(BD_Producto producto) {
            try {

                iproducto.insertarProducto(producto);
                
                return true;
            } catch (Exception ex) {

                MessageBox.Show("+CN_Producto:insertarProducto: "+ex.Message);
                return false;
            }
        }
        public bool eliminarProducto(int? id_producto) {

            try
            {
                
                return iproducto.eliminarProducto(id_producto);
            }
            catch (Exception ex)
            {

                MessageBox.Show("+CN_Producto:insertarProducto: "+ex.Message);
                return false;
            }

        }
        public bool actualizarProducto(BD_Producto producto) {

            try
            {
                if (producto.Id_Pro > 0)
                {
                    
                    return iproducto.actualizarProducto(producto);
                }
                else {

                    return false;
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("+CN_Producto:insertarProducto: "+ex.Message);
                return false;
            }

        }
        public BD_Producto obtenerproducto(int id_Producto) {

            try
            {
                BD_Producto producto = iproducto.obtenerproducto(id_Producto);
                
                return producto;
            }
            catch (Exception ex)
            {

                MessageBox.Show("+CN_Producto:insertarProducto: "+ex.Message);
                return null;
            }
        }
        public void obtenerProductos(DataGridView dataGridView) {

            try {

                Utilidades.cargarGrid(iproducto.obtenerProductos(),dataGridView);

            } catch (Exception ex) {

                MessageBox.Show("+CN_Producto:obtenerProductos: "+ex.Message);
            }
        }
        public void obtenerProductosPor(String descripcion_l, String proveedor,DataGridView dataGridView) {

            try
            {

                Utilidades.cargarGrid(iproducto.obtenerProductosPor(descripcion_l,proveedor), dataGridView);

            }
            catch (Exception ex)
            {

                MessageBox.Show("+CN_Producto:obtenerProductosPor: "+ex.Message);
            }

        }
        public void listarCategoria(ComboBox comboBox) {

            try
            {

                Utilidades.cargarComboBox(iproducto.listarCategoria(), comboBox, "Id_Cat", "Categoria");

            }
            catch (Exception ex)
            {

                MessageBox.Show("+CN_Producto:obtenerProductosPor: " + ex.Message);
            }

        }
        public void listarMarca(ComboBox comboBox) {

            try
            {
                Utilidades.cargarComboBox(iproducto.listarMarca(), comboBox,"Id_Marca","Marca");
            }
            catch (Exception ex)
            {

                MessageBox.Show("+CN_Producto:listarMarca: " + ex.Message);
            }


        }
        public void listarProveedores(ComboBox comboBox) {

            try {

                Utilidades.cargarComboBox(iproducto.listarProveedor(), comboBox, "idProvee", "nombre");
                
            } catch (Exception ex) {

                MessageBox.Show("+CN_Producto-listarProveedores: "+ex.Message);
            }

        }
        public void listarUnidadMedida(ComboBox comboBox) {

            try
            {
                Dictionary<String, String> unidadesMedida = new Dictionary<String, string>();

                unidadesMedida.Add("H87", "Pieza");
                unidadesMedida.Add("MTR", "Metro");
                unidadesMedida.Add("LTR", "Litro");
                unidadesMedida.Add("DPC", "Docena de piezas");
                
                Utilidades.cargarComboSinBaseDatos(unidadesMedida, comboBox);

            }
            catch (Exception ex)
            {
                MessageBox.Show("+CN_Producto-listarProveedores: " + ex.Message);
            }


        }
        
    }
}
