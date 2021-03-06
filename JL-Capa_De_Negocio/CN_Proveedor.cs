﻿using JL_Entidades;
using JL_Modelos;
using JL_Modelos.Interfaces;
using JL_Utilidades;
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

        public void llenarProveedores(DataGridView datagridview) {
            try {
                datagridview.Rows.Clear();
                foreach (var item in iproveedor.obtenerProveedores())
                {
                    datagridview.Rows.Add(item.idProvee, item.nombre, item.direccion,
                        item.telefono, item.rfc, item.correo);
                }
            } catch (Exception ex) {
                MessageBox.Show("+CN_Proveedor-llenarProveedores: " + ex.Message);
            }
        }

        public void llenarProveedoresPor(DataGridView datagridview,String datos) {

            try
            {
                datagridview.Rows.Clear();
                foreach (var item in iproveedor.obtenerProveedorPor(datos, datos, datos))
                {
                    datagridview.Rows.Add(item.idProvee,item.nombre,item.direccion,
                        item.telefono,item.rfc,item.correo);
                }

                //Utilidades.cargarGrid(iproveedor.obtenerProveedorPor(datos, datos, datos), datagridview); 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("+CN_Proveedor-llenarProveedores: " + ex.Message);
            }
        }

        public BD_Proveedor seleccionaProveedorProId(int id) {

            try {
                return iproveedor.buscarProveedorPorId(id);
            } catch (Exception ex) {

                MessageBox.Show("+CN_Proveedor-seleccionaProveedorProId: "+ex.Message);
                return null;
                
            }


        }

    }
}
