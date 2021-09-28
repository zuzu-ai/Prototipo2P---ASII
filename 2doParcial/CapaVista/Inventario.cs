using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaContolador;

namespace CapaVista
{
    public partial class Inventario : UserControl
    {
        Controlador cn = new Controlador();
        string estado = "";
        public Inventario()
        {
            InitializeComponent();
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
            actualizarProducto();
            funLimpiar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == ""  && txtNombre.Text == "" && txtPrecio.Text == "" && txtCosto.Text == "" && txtExistencias.Text == "")
            {
                MessageBox.Show("Una o más casillas están vacías.");
            }
            else
            {
                cn.llamarInsertProducto(txtID.Text, txtNombre.Text, txtCosto.Text, txtPrecio.Text, txtExistencias.Text, estado);
                MessageBox.Show("Ingreso exitoso.");
                funLimpiar();
            }
            actualizarProducto();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" && txtNombre.Text == "" && txtPrecio.Text == "" && txtCosto.Text == "" && txtExistencias.Text == "")
            {
                MessageBox.Show("Debe llenar las casillas para modificar el registro.");
            }
            else
            {
                cn.llamarModifProducto(txtID.Text, txtNombre.Text, txtCosto.Text, txtPrecio.Text, txtExistencias.Text, estado);
                MessageBox.Show("Modificación exitosa.");
                funLimpiar();
            }
            actualizarProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" && txtNombre.Text == "" && txtPrecio.Text == "" && txtCosto.Text == "" && txtExistencias.Text == "")
            {
                MessageBox.Show("No se puede buscar un registro para eliminar.");
            }
            else
            {
                cn.llamarElimProducto(txtID.Text);
                MessageBox.Show("Registro eliminado.");
                funLimpiar();
            }
            actualizarProducto();
    }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtCosto.Text = "";
            txtPrecio.Text = "";
            txtExistencias.Text = "";
            estado = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
        }
        private void funLimpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtCosto.Text = "";
            txtPrecio.Text = "";
            txtExistencias.Text = "";
            estado = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
        }
        string tabla1 = "inventario";
        public void actualizarProducto()
        {
            DataTable dt = cn.llenarProducto(tabla1);
            dgvProducto.DataSource = dt;
        }

		private void dgvProducto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
            try
            {
                txtID.Text = dgvProducto.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvProducto.CurrentRow.Cells[1].Value.ToString();
                txtCosto.Text = dgvProducto.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = dgvProducto.CurrentRow.Cells[3].Value.ToString();
                txtExistencias.Text = dgvProducto.CurrentRow.Cells[4].Value.ToString();
                estado = dgvProducto.CurrentRow.Cells[5].Value.ToString();

                if (estado == "1")
                {
                    rbActivo.Checked = true;
                    rbInactivo.Checked = false;
                }
                else
                {
                    rbActivo.Checked = false;
                    rbInactivo.Checked = true;
                }
            }
            catch
            {

            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

		private void rbActivo_CheckedChanged(object sender, EventArgs e)
		{
            estado = "1";
        }

		private void rbInactivo_CheckedChanged(object sender, EventArgs e)
		{
            estado = "0";
        }
	}
}
