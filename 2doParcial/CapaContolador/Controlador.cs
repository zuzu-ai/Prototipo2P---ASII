using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaContolador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();
        //Empleado

        public void llamarInsertEmpleado(string id, string dpi, string nombre, string apellido, string direccion, string telefono, string estado) {

            sn.funInsertarEmpleado(id, dpi, nombre, apellido, direccion, telefono, estado);
        }

        public void llamarModifEmpleado(string id, string dpi, string nombre, string apellido, string direccion, string telefono, string estado)
        {

            sn.funModifEmpleado(id, dpi, nombre, apellido, direccion, telefono, estado);
        }

        public void llamarElimEmpleado(string id)
        {

            sn.funElimEmpleado(id);
        }
        public DataTable llenarEmpleado(string tabla1)
        {
            OdbcDataAdapter dt = sn.llenarEmpleado(tabla1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Usuario
        public OdbcDataReader llenarcbxEmpleado()
        {
            string sql = "SELECT nombre_empleado FROM segundoparcial.empleado;";
            return sn.llenarcbxEmpleado(sql);
        }
        public string consultaIdEmpleado(string nombre)
        {
            string id = sn.consultaIdEmpleado(nombre);
            return id;
        }
        public void llamarInsertUsurio(string id, string idempleado, string nombre, string contraseña, string estado)
        {

            sn.funInsertarUsuario(id, idempleado, nombre, contraseña, estado);
        }

        public void llamarModifUsuario(string id, string idempleado, string nombre, string coanrtraseña, string estado)
        {

            sn.funModifUsuario(id, idempleado, nombre, coanrtraseña, estado);
        }

        public void llamarElimUsurio(string id)
        {

            sn.funElimEmpleado(id);
        }

        //Cliente

        public void llamarInsertCliente(string id, string nit, string nombre, string apellido, string direccion, string telefono, string estado)
        {

            sn.funInsertarCliente(id, nit, nombre, apellido, direccion, telefono, estado);
        }

        public void llamarModifCliente(string id, string nit, string nombre, string apellido, string direccion, string telefono, string estado)
        {

            sn.funModifCliente(id, nit, nombre, apellido, direccion, telefono, estado);
        }

        public void llamarElimCliente(string id)
        {

            sn.funElimCliente(id);
        }
        public DataTable llenarCliente(string tabla1)
        {
            OdbcDataAdapter dt = sn.llenarCliente(tabla1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Producto

        public void llamarInsertProducto(string id, string nombre, string costo, string precio, string existencias, string estado)
        {

            sn.funInsertarProducto(id, nombre, costo, precio, existencias, estado);
        }

        public void llamarModifProducto(string id, string nombre, string costo, string precio, string existencias, string estado)
        {

            sn.funModifProducto(id, nombre, costo, precio, existencias, estado);
        }

        public void llamarElimProducto(string id)
        {

            sn.funElimProducto(id);
        }
        public DataTable llenarProducto(string tabla1)
        {
            OdbcDataAdapter dt = sn.llenarProducto(tabla1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Factura
        public OdbcDataReader llenarcbxCliente()
        {
            string sql = "SELECT nombre_cliente FROM segundoparcial.cliente;";
            return sn.llenarcbxCliente(sql);
        }
        public string consultaIdCliente(string nombre)
        {
            string id = sn.consultaIdCliente(nombre);
            return id;
        }
        public string consultaNitCliente(string nombre)
        {
            string nit = sn.consultaNitCliente(nombre);
            return nit;
        }

        public OdbcDataReader llenarcbxProducto()
        {
            string sql = "SELECT nombre_producto FROM segundoparcial.inventario;";
            return sn.llenarcbxCliente(sql);
        }
        public string consultaIdProducto(string nombre)
        {
            string id = sn.consultaIdProducto(nombre);
            return id;
        }

        public void llamarInsertFacturaE(int id, string cliente, string fecha, float total, string estado)
        {

            sn.funInsertarFacturaE(id,cliente,fecha,total,estado);
        }

        public void llamarModifFacturaE(string id, string cliente, string fecha, string total, string estado)
        {

            sn.funModifFacturaE(id, cliente, fecha, total, estado);
        }

        public void llamarElimFacturaE(string id)
        {

            sn.funElimFacturaE(id);
        }

        public void llamarInsertFacturaD(string id, string enca, string producto, string subtotal)
        {

            sn.funInsertarFacturaD(id,enca,producto,subtotal);
        }

        public void llamarModifFacturaD(string id, string enca, string producto, string subtotal)
        {

            sn.funModifFacturaD(id, enca, producto, subtotal);
        }

        public void llamarElimFacturaD(string id)
        {

            sn.funElimFacturaD(id);
        }

        public DataTable llenarFacturaE(string tabla1)
        {
            OdbcDataAdapter dt = sn.llenarFacturaE(tabla1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarFacturaD(string tabla2)
        {
            OdbcDataAdapter dt = sn.llenarFacturaD(tabla2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public string consultaPrecioProd(string nombre)
        {
            string precio = sn.consultaPrecioProd(nombre);
            return precio;
        }
    }
}

