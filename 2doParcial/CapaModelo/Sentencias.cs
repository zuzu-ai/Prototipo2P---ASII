using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Sentencias
    {
        Conexion cn = new Conexion();

        //Empleado
        public void funInsertarEmpleado(string id, string dpi, string nombre, string apellido, string direccion, string telefono, string estado)
        {

            string cadena = "INSERT INTO Empleado VALUES ('" + id + "','" + dpi + "','" + nombre + "','" + apellido + "','" + direccion + "','" + telefono + "','" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        public void funModifEmpleado(string id, string dpi, string nombre, string apellido, string direccion, string telefono, string estado)
        {
            string cadena = "UPDATE Empleado SET dpi_empleado= '" + dpi + "', nombre_empleado= '" + nombre + "', apellido_empleado='" + apellido + "', direccion_empleado= '" + direccion + "', telefono_empleado= '" + telefono + "', estado_empleado= '" + estado + "' WHERE id_empleado= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funElimEmpleado(string id)
        {
            string cadena = "DELETE FROM Empleado WHERE id_empleado= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public OdbcDataAdapter llenarEmpleado(string tabla1)// metodo  que obtinene el contenido de una tabla
        {

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla1 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Usuarios
        public OdbcDataReader llenarcbxEmpleado(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public string consultaIdEmpleado(string nombre)
        {
            string id = "";
            string Query = "select * from Empleado where nombre_empleado='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {
                id = busqueda["id_empleado"].ToString();
            }
            return id;
        }

        public void funInsertarUsuario(string id, string idempleado, string nombre, string caontraseña, string estado)
        {

            string cadena = "INSERT INTO usuario VALUES ('" + id + "','" + idempleado + "','" + nombre + "','" + caontraseña + "','" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        public void funModifUsuario(string id, string idempleado, string nombre, string contraseña, string estado)
        {
            string cadena = "UPDATE usuario SET id_empleado= '" + idempleado + "', nombre_usuario= '" + nombre + "', contraseña_usuario='" + contraseña + "', estado_usuario= '" + estado + "' WHERE id_empleado= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funElimUsuario(string id)
        {
            string cadena = "DELETE FROM usuario WHERE id_usuario= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public OdbcDataAdapter llenarUsuario(string tabla1)// metodo  que obtinene el contenido de una tabla
        {

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla1 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Cliente

        public void funInsertarCliente(string id, string nit, string nombre, string apellido, string direccion, string telefono, string estado)
        {

            string cadena = "INSERT INTO Cliente VALUES ('" + id + "','" + nit + "','" + nombre + "','" + apellido + "','" + direccion + "','" + telefono + "','" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        public void funModifCliente(string id, string nit, string nombre, string apellido, string direccion, string telefono, string estado)
        {
            string cadena = "UPDATE Cliente SET nit_cliente= '" + nit + "', nombre_cliente= '" + nombre + "', apellido_cliente='" + apellido + "', direccion_cliente= '" + direccion + "', telefono_cliente= '" + telefono + "', estado_cliente= '" + estado + "' WHERE id_cliente= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funElimCliente(string id)
        {
            string cadena = "DELETE FROM Cliente WHERE id_cliente= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public OdbcDataAdapter llenarCliente(string tabla1)// metodo  que obtinene el contenido de una tabla
        {

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla1 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Producto

        public void funInsertarProducto(string id, string nombre, string costo, string precio, string existencias, string estado)
        {

            string cadena = "INSERT INTO Inventario VALUES ('" + id + "','" + nombre + "'," + costo + "," + precio + "," + existencias + ",'" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        public void funModifProducto(string id, string nombre, string costo, string precio, string existencias, string estado)
        {
            string cadena = "UPDATE Inventario SET nombre_producto= '" + nombre + "', costo_producto= " + costo + ", precio_venta=" + precio + ", existencia_producto= " + existencias + ", estado_producto= '" + estado + "' WHERE id_inventario= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funElimProducto (string id)
        {
            string cadena = "DELETE FROM Inventario WHERE id_inventario= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public OdbcDataAdapter llenarProducto(string tabla1)// metodo  que obtinene el contenido de una tabla
        {

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla1 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Factura
        public OdbcDataReader llenarcbxCliente(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public string consultaIdCliente(string nombre)
        {
            string id = "";
            string Query = "select * from Cliente where nombre_cliente='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {
                id = busqueda["id_cliente"].ToString();
            }
            return id;
        }

        public OdbcDataReader llenarcbxProducto(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public string consultaIdProducto(string nombre)
        {
            string id = "";
            string Query = "select * from inventario where nombre_producto='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {
                id = busqueda["id_inventario"].ToString();
            }
            return id;
        }

        public string consultaNitCliente(string nombre)
        {
            string nit = "";
            string Query = "select * from Cliente where nombre_cliente='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {
                nit = busqueda["nit_cliente"].ToString();
            }
            return nit;
        }

        public void funInsertarFacturaE(int id, string cliente, string fecha, float total, string estado)
        {

            string cadena = "INSERT INTO factura_enca VALUES ('" + id + "','" + cliente + "','" + fecha + "','" + total + "','" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        public void funModifFacturaE(string id, string cliente, string fecha, string total, string estado)
        {
            string cadena = "UPDATE factura_enca SET id_cliente= '" + cliente + "', fecha='" + fecha + "', total_factura='" + total + "', estado_factura= '" + estado + "' WHERE id_factura_enca= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funElimFacturaE(string id)
        {
            string cadena = "DELETE FROM factura_enca WHERE id_factura_enca= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funInsertarFacturaD(string id, string enca, string producto, string subtotal)
        {

            string cadena = "INSERT INTO factura_detalle VALUES ('" + id + "','" + enca + "','" + producto + "','" + subtotal + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        public void funModifFacturaD(string id, string enca, string producto, string subtotal)
        {
            string cadena = "UPDATE factura_detalle SET id_factura_enca= '" + enca + "', id_inventario='" + producto + "', subtotal_detalle='" + subtotal + "' WHERE id_factura_detalle= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funElimFacturaD(string id)
        {
            string cadena = "DELETE FROM factura_detalle WHERE id_factura_detalle= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public OdbcDataAdapter llenarFacturaE(string tabla1)// metodo  que obtinene el contenido de una tabla
        {

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla1 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarFacturaD(string tabla2)// metodo  que obtinene el contenido de una tabla
        {

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla2 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public string consultaPrecioProd(string nombre)
        {
            string id = "";
            string Query = "select * from Inventario where nombre_producto='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {
                id = busqueda["precio_venta"].ToString();
            }
            return id;
        }
    }
}
