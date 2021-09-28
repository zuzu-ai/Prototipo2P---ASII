using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaContolador;

namespace CapaVista
{
	public partial class Factura : UserControl
	{
		Controlador cn = new Controlador();
		string estado = "0";
		int total = 0;
		public Factura()
		{
			InitializeComponent();
			llenarcbxCliente();
			llenarcbxProducto();
			actualizarTablas();
			funLimpiar();
		}

		public void enviarfecha()
		{
			txtFecha.Text = dtpFecha.Text;
		}
		public void llenarcbxCliente()
		{
			try
			{
				cbxCliente.Items.Clear();
				OdbcDataReader datareader = cn.llenarcbxCliente();
				cbxCliente.Items.Add("Selecione un Cliente");
				while (datareader.Read())
				{
					cbxCliente.Items.Add(datareader[0].ToString());
				}
				cbxCliente.SelectedIndex = 0;
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		public string consultaIdCliente(string nombre)
		{
			string id_cliente = cn.consultaIdCliente(nombre);
			return id_cliente;
		}

		public string consultaNitCliente(string nombre)
		{
			string id_empleado = cn.consultaNitCliente(nombre);
			return id_empleado;
		}

		public void llenarcbxProducto()
		{
			try
			{
				cbxProducto.Items.Clear();
				OdbcDataReader datareader = cn.llenarcbxProducto();
				cbxProducto.Items.Add("Selecione un Producto");
				while (datareader.Read())
				{
					cbxProducto.Items.Add(datareader[0].ToString());
				}
				cbxProducto.SelectedIndex = 0;
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		public string consultaIdProducto(string nombre)
		{
			string id_producto = cn.consultaIdProducto(nombre);
			return id_producto;
		}

		public string consultaPrecioProd(string nombre)
		{
			string precio_venta = cn.consultaPrecioProd(nombre);
			return precio_venta;
		}

		string tabla1 = "factura_enca";
		string tabla2 = "factura_detalle";
		public void actualizarFacturaE()
		{
			DataTable dt = cn.llenarFacturaE(tabla1);
			dgvFacturaE.DataSource = dt;
		}

		public void actualizarFacturaD()
		{
			DataTable dt = cn.llenarFacturaD(tabla2);
			dgvFacturaD.DataSource = dt;
		}

		public void actualizarTablas()
		{
			actualizarFacturaE();
			actualizarFacturaD();
		}



		private void btnGuardarEncabezado_Click(object sender, EventArgs e)
		{
			if (txtID.Text == "" && lblIdCliente.Text == "" && txtFecha.Text == "")
			{
				MessageBox.Show("Una o más casillas obligatorias están vacías.");
			}
			else
			{
				cn.llamarInsertFacturaE(Int32.Parse(txtID.Text), lblIdCliente.Text, txtFecha.Text, total, estado);
				MessageBox.Show("Encabezado Registrado.");

			}
			actualizarFacturaE();
			txtID.Enabled = false;
			cbxCliente.Enabled = false;
			dtpFecha.Enabled = false;
			rbActivo.Enabled = false;
			rbInactivo.Enabled = false;
			btnLimpiar.Enabled = false;
		}

		private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblIdCliente.Text = consultaIdCliente(cbxCliente.Text);
			lblNit.Text = consultaNitCliente(cbxCliente.Text);
			enviarfecha();
		}

		private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblIdProducto.Text = consultaIdProducto(cbxProducto.Text);
			txtPrecio.Text= consultaPrecioProd(cbxProducto.Text);
		}

		private void rbActivo_CheckedChanged(object sender, EventArgs e)
		{
			estado = "1";
		}

		private void rbInactivo_CheckedChanged(object sender, EventArgs e)
		{
			estado = "0";
		}

		private void dtpFecha_ValueChanged(object sender, EventArgs e)
		{
			enviarfecha();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtID.Text = "";
			cbxCliente.SelectedIndex = 0;
			lblIdCliente.Text = "";
			lblNit.Text = "";
			txtFecha.Text = "";
			string d = DateTime.Now.ToString();
			dtpFecha.Text = d;
			rbActivo.Checked = false;
			rbInactivo.Checked = false;

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			cn.llamarElimFacturaE(txtID.Text);
			actualizarFacturaE();
			txtID.Text = "";
			cbxCliente.SelectedIndex = 0;
			lblIdCliente.Text = "";
			lblNit.Text = "";
			txtFecha.Text = "";
			rbActivo.Enabled = true;
			rbInactivo.Enabled = true;
			rbActivo.Checked = false;
			rbInactivo.Checked = false;
			cbxCliente.Enabled = true;
			cbxProducto.Enabled = true;
			txtID.Enabled = true;
			dtpFecha.Enabled = true;
			btnLimpiar.Enabled = true;
		}

		private void funLimpiar()
		{
			txtID.Text = "";
			cbxCliente.SelectedIndex = 0;
			lblIdCliente.Text = "";
			lblNit.Text = "";
			txtFecha.Text = "";
			btnLimpiar.Enabled = true;
			txtIdDetalle.Text = "";
			cbxProducto.SelectedIndex = 0;
			lblIdProducto.Text = "";
			txtPrecio.Text = "";

			rbActivo.Checked = false;
			rbInactivo.Checked = false;

			txtID.Enabled = true;
			cbxCliente.Enabled = true;
			dtpFecha.Enabled = true;

			btnLimpiar.Enabled = true;


		}

		private void dgvFacturaE_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (txtID.Text == "" && lblIdProducto.Text == "" && txtPrecio.Text == "")
			{
				MessageBox.Show("Una o más casillas obligatorias están vacías.");
			}
			else
			{
				cn.llamarInsertFacturaD("0", txtID.Text, lblIdProducto.Text, txtPrecio.Text);

			}
		}

		private void Factura_Load(object sender, EventArgs e)
		{
			
		}
	}
}
