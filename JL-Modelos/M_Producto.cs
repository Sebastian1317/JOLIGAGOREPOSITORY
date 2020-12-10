using JL_Entidades;
using JL_Modelos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Modelos
{
    public class M_Producto : M_IProducto
    {
        BD_BaseDeDatos baseDeDatosC = new BD_BaseDeDatos();
        SqlConnection cnn = null;

        public M_Producto()
        {
            cnn = new SqlConnection(baseDeDatosC.cadenaConexion());
        }

        public bool actualizarProducto(BD_Producto producto)
        {
            try
            {

                cnn.Open();
                SqlCommand command = new SqlCommand("actualizarProducto", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_Pro",producto.Id_Pro);
                command.Parameters.AddWithValue("@IDPROVEE",producto.idProvee.idProvee);
                command.Parameters.AddWithValue("@Descripcion_Larga", producto.descripcion_larga);
                command.Parameters.AddWithValue("@Frank", producto.frank);
                command.Parameters.AddWithValue("@Pre_CompraS", producto.pre_CompraS);
                command.Parameters.AddWithValue("@Pre_Compra$", producto.pre_CompraD);
                command.Parameters.AddWithValue("@Stock_Actual",producto.stock_Actual);
                command.Parameters.AddWithValue("@Id_Cat",producto.id_Cat.Id_Cat);
                command.Parameters.AddWithValue("@Id_Marca", producto.id_Marca.Id_Marca);
                command.Parameters.AddWithValue("@Foto", producto.foto);
                command.Parameters.AddWithValue("@Pre_vntaxMenor", producto.pre_vntaxMenor);
                command.Parameters.AddWithValue("@Pre_vntaxMayor", producto.pre_vntaxMayor);
                command.Parameters.AddWithValue("@Pre_Vntadolar", producto.pre_Vntadolar);
                command.Parameters.AddWithValue("@UndMedida", producto.undMedida);
                command.Parameters.AddWithValue("@PesoUnit", producto.pesoUnit);
                command.Parameters.AddWithValue("@UtilidadUnit", producto.utilidadUnit);
                command.Parameters.AddWithValue("@TipoProdcto", producto.tipoProdcto);
                command.Parameters.AddWithValue("@Valor_porCant", producto.valor_porCant);

                command.ExecuteNonQuery();



                cnn.Close();

                return true;

            }
            catch (Exception ex)
            {

                cnn.Close();
                throw new Exception("M_Producto-actualizarProducto: " + ex.Message);
            }
        }

        public bool eliminarProducto(int? id_producto)
        {
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("eliminarProducto", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_Pro", id_producto);

                command.ExecuteNonQuery();

                cnn.Close();

                return true;

            }
            catch (Exception ex)
            {

                cnn.Close();
                throw new Exception("M_Producto-eliminarProducto: " + ex.Message);
            }
        }

        public bool insertarProducto(BD_Producto producto)
        {
            try
            {

                cnn.Open();
                SqlCommand command = new SqlCommand("insertarProducto", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_Pro", producto.Id_Pro);
                command.Parameters.AddWithValue("@IDPROVEE", producto.idProvee);
                command.Parameters.AddWithValue("@Descripcion_Larga", producto.descripcion_larga);
                command.Parameters.AddWithValue("@Frank", producto.frank);
                command.Parameters.AddWithValue("@Pre_CompraS", producto.pre_CompraS);
                command.Parameters.AddWithValue("@Pre_Compra$", producto.pre_CompraD);
                command.Parameters.AddWithValue("@Stock_Actual", producto.stock_Actual);
                command.Parameters.AddWithValue("@Id_Cat", producto.id_Cat);
                command.Parameters.AddWithValue("@Id_Marca", producto.id_Marca);
                command.Parameters.AddWithValue("@Foto", producto.foto);
                command.Parameters.AddWithValue("@Pre_vntaxMenor", producto.pre_vntaxMenor);
                command.Parameters.AddWithValue("@Pre_vntaxMayor", producto.pre_vntaxMayor);
                command.Parameters.AddWithValue("@Pre_Vntadolar", producto.pre_Vntadolar);
                command.Parameters.AddWithValue("@UndMedida", producto.undMedida);
                command.Parameters.AddWithValue("@PesoUnit", producto.pesoUnit);
                command.Parameters.AddWithValue("@UtilidadUnit", producto.utilidadUnit);
                command.Parameters.AddWithValue("@TipoProdcto", producto.tipoProdcto);
                command.Parameters.AddWithValue("@Valor_porCant", producto.valor_porCant);
                command.Parameters.AddWithValue("@Estado_Pro", producto.estado_Pro);

                command.ExecuteNonQuery();



                cnn.Close();

                return true;

            }
            catch (Exception ex)
            {

                cnn.Close();
                throw new Exception("M_Producto-insertarProducto: " + ex.Message);
            }
        }

        public List<BD_Categoria> listarCategoria()
        {
            List<BD_Categoria> categorias = new List<BD_Categoria>();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("seleccionarCategoria", cnn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    BD_Categoria categoria = null;
                    while (reader.Read())
                    {
                        categoria = new BD_Categoria();
                        categoria.Id_Cat = int.Parse(reader["Id_Cat"].ToString());
                        categoria.Categoria = reader["Categoria"].ToString();
                        categorias.Add(categoria);
                    }
                    cnn.Close();
                    return categorias;

                }
                else
                {
                    cnn.Close();
                    return null;

                }

            }
            catch (Exception ex)
            {
                cnn.Close();
                categorias = null;
                throw new Exception("CN_Productos-listarCategoria+ " + ex.Message);
            }
        }

        public List<BD_Marca> listarMarca()
        {
            List<BD_Marca> marcas = new List<BD_Marca>();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("seleccionarMarca", cnn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    BD_Marca marca = null;
                    while (reader.Read())
                    {
                        marca = new BD_Marca();
                        marca.Id_Marca = int.Parse(reader["Id_Marca"].ToString());
                        marca.Marca = reader["Marca"].ToString();
                        marcas.Add(marca);
                    }
                    cnn.Close();
                    return marcas;

                }
                else
                {
                    cnn.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                cnn.Close();
                marcas = null;
                throw new Exception("CN_Productos-listarMarca+ " + ex.Message);
            }
        }

        public List<BD_Proveedor> listarProveedor()
        {
            List<BD_Proveedor> proveedores = new List<BD_Proveedor>();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("proveedoresComboBox", cnn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {

                    BD_Proveedor proveedor = null;
                    while (reader.Read())
                    {
                        proveedor = new BD_Proveedor();
                        proveedor.idProvee = int.Parse(reader["IDPROVEE"].ToString());
                        proveedor.nombre = reader["NOMBRE"].ToString();
                        proveedores.Add(proveedor);
                    }
                    cnn.Close();
                    return proveedores;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                cnn.Close();
                proveedores = null;
                throw new Exception("CN_Productos-listarProveedor+ " + ex.Message);
            }
        }

        public BD_Producto obtenerproducto(int id_Producto)
        {
            BD_Producto producto = new BD_Producto();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("seleccionarProducto", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id_Pro", id_Producto);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        producto.Id_Pro = id_Producto;
                        producto.idProvee.idProvee = int.Parse(reader["IDPROVEE"].ToString());
                        producto.descripcion_larga= reader["Descripcion_Larga"].ToString();
                        producto.frank= decimal.Parse(reader["Frank"].ToString());
                        producto.pre_CompraS= decimal.Parse(reader["Pre_CompraS"].ToString());
                        producto.pre_CompraD= decimal.Parse(reader["Pre_Compra$"].ToString());
                        producto.stock_Actual= decimal.Parse(reader["Stock_Actual"].ToString());
                        producto.id_Cat.Id_Cat= int.Parse(reader["Id_Cat"].ToString());
                        producto.id_Marca.Id_Marca= int.Parse(reader["Id_Marca"].ToString());
                        producto.foto= reader["Foto"].ToString();
                        producto.pre_vntaxMenor= decimal.Parse(reader["Pre_vntaxMenor"].ToString());
                        producto.pre_vntaxMayor=decimal.Parse( reader["Pre_vntaxMayor"].ToString());
                        producto.pre_Vntadolar=decimal.Parse(reader["Pre_Vntadolar"].ToString());
                        producto.undMedida= char.Parse(reader["UndMedida"].ToString());
                        producto.pesoUnit= decimal.Parse(reader["PesoUnit"].ToString());
                        producto.utilidadUnit= decimal.Parse(reader["UtilidadUnit"].ToString());
                        producto.tipoProdcto= reader["TipoProdcto"].ToString();
                        producto.valor_porCant=decimal.Parse(reader["Valor_porCant"].ToString());
                        producto.estado_Pro= reader["Estado_Pro"].ToString();
                        
                    }
                    cnn.Close();
                    return producto;

                }
                else
                {
                    cnn.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                cnn.Close();
                producto = null;
                throw new Exception("CN_Productos-listarMarca+ " + ex.Message);
            }
        }

        public List<BD_Producto> obtenerProductos()
        {
            List<BD_Producto> productos = new List<BD_Producto>();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("seleccionarProductos", cnn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    BD_Producto producto = null;

                    while (reader.Read())
                    {
                         producto = new BD_Producto();

                        producto.idProvee.idProvee = int.Parse(reader["NOMBRE"].ToString());
                        producto.descripcion_larga = reader["Descripcion_Larga"].ToString();
                        producto.pre_CompraS = decimal.Parse(reader["Pre_CompraS"].ToString());
                        producto.pre_CompraD = decimal.Parse(reader["Pre_Compra$"].ToString());
                        producto.stock_Actual = decimal.Parse(reader["Stock_Actual"].ToString());
                        producto.id_Cat.Categoria = reader["Categoria"].ToString();
                        producto.id_Marca.Marca = reader["Marca"].ToString();
                        producto.pre_vntaxMenor = decimal.Parse(reader["Pre_vntaxMenor"].ToString());
                        producto.pre_vntaxMayor = decimal.Parse(reader["Pre_vntaxMayor"].ToString());
                        producto.undMedida = char.Parse(reader["UndMedida"].ToString());
                        producto.pesoUnit = decimal.Parse(reader["PesoUnit"].ToString());
                        producto.tipoProdcto = reader["TipoProdcto"].ToString();
                        producto.valor_porCant = decimal.Parse(reader["Valor_porCant"].ToString());
                        producto.estado_Pro = reader["Estado_Pro"].ToString();

                        productos.Add(producto);
                    }
                    cnn.Close();
                    return productos;

                }
                else
                {
                    cnn.Close();
                    return null;

                }

            }
            catch (Exception ex)
            {
                cnn.Close();
                productos = null;
                throw new Exception("CN_Producto-obtenerProductos+ " + ex.Message);
            }
            }

        public List<BD_Producto> obtenerProductosPor(string descripcion_l, string proveedor)
        {
            List<BD_Producto> productos = new List<BD_Producto>();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("seleccionarProductosPor", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Descripcion_Larga", descripcion_l);
                command.Parameters.AddWithValue("@NOMBRE", proveedor);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    BD_Producto producto = null;

                    while (reader.Read())
                    {
                        producto = new BD_Producto();

                        producto.idProvee.idProvee = int.Parse(reader["NOMBRE"].ToString());
                        producto.descripcion_larga = reader["Descripcion_Larga"].ToString();
                        producto.pre_CompraS = decimal.Parse(reader["Pre_CompraS"].ToString());
                        producto.pre_CompraD = decimal.Parse(reader["Pre_Compra$"].ToString());
                        producto.stock_Actual = decimal.Parse(reader["Stock_Actual"].ToString());
                        producto.id_Cat.Categoria = reader["Categoria"].ToString();
                        producto.id_Marca.Marca = reader["Marca"].ToString();
                        producto.pre_vntaxMenor = decimal.Parse(reader["Pre_vntaxMenor"].ToString());
                        producto.pre_vntaxMayor = decimal.Parse(reader["Pre_vntaxMayor"].ToString());
                        producto.undMedida = char.Parse(reader["UndMedida"].ToString());
                        producto.pesoUnit = decimal.Parse(reader["PesoUnit"].ToString());
                        producto.tipoProdcto = reader["TipoProdcto"].ToString();
                        producto.valor_porCant = decimal.Parse(reader["Valor_porCant"].ToString());
                        producto.estado_Pro = reader["Estado_Pro"].ToString();

                        productos.Add(producto);
                    }
                    cnn.Close();
                    return productos;

                }
                else
                {
                    cnn.Close();
                    return null;

                }

            }
            catch (Exception ex)
            {
                cnn.Close();
                productos = null;
                throw new Exception("CN_Producto-obtenerProductosPor+ " + ex.Message);
            }
        }
    }
    
    }
