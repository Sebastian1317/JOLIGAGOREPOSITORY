using JL_Entidades;
using JL_Modelos;
using JL_Modelos.Interfaces;
using JL_Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JL_Capa_De_Negocio
{
  public class CN_Proveedor
    {
        private M_IProveedor iproveedor= new M_Proveedor();

        public bool insertarProveedor(BD_Proveedor proveedor) {

            try {

                if (proveedor != null)
                {
                    if (ValidacionesRegex.validarEmail(proveedor.correo))
                    {

                        return iproveedor.insertarProveedor(proveedor);
                    }
                    else {
                        MessageBox.Show("El email es incorrecto");
                        return false;
                    }
                }
                else {
                    return false;
                }

            } catch (Exception ex) {


                MessageBox.Show("+M_Proveedor-insertarProveedor: "+ex.Message);
                return false;
            }
        }

        public bool actualizarProveedor(BD_Proveedor proveedor)
        {
            try
            {

                if (proveedor != null)
                {
                    if (ValidacionesRegex.validarEmail(proveedor.correo))
                    {

                        return iproveedor.actualizarProveedor(proveedor);
                    }
                    else
                    {
                        MessageBox.Show("El email es incorrecto");
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {


                MessageBox.Show("+M_Proveedor-actualizarProveedor: " + ex.Message);
                return false;
            }
        }

        public bool eliminarProveedor(int? idProveedor)
        {
            try
            {
                if ((int?) idProveedor != null)
                {
                    return iproveedor.eliminarProveedor(idProveedor);
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {


                MessageBox.Show("+M_Proveedor-eliminarProveedor: " + ex.Message);
                return false;
            }
        }

    }
}
