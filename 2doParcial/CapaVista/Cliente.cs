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
    public partial class Cliente : UserControl
    {
        Controlador cn = new Controlador();
        string estado = "";
        public Cliente()
        {
            InitializeComponent();
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
            actualizarCliente();
            funLimpiar();
        }

		private void btnInsertar_Click(object sender, EventArgs e)
		{
            if (txtID.Text == "" && txtNit.Text == "" && txtNombre.Text == "" && txtApellido.Text == "" && txtDireccion.Text == "" && txtTelefono.Text == "")
            {
                MessageBox.Show("Una o más casillas están vacías.");
            }
            else
            {
                cn.llamarInsertCliente(txtID.Text, txtNit.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, estado);
                MessageBox.Show("Ingreso exitoso.");
                funLimpiar();
            }
            actualizarCliente();
        }

		private void btnModificar_Click(object sender, EventArgs e)
		{
            if (txtID.Text == "" && txtNit.Text == "" && txtNombre.Text == "" && txtApellido.Text == "" && txtDireccion.Text == "" && txtTelefono.Text == "")
            {
                MessageBox.Show("Debe llenar las casillas para modificar el registro.");
            }
            else
            {
                cn.llamarModifCliente(txtID.Text, txtNit.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, estado);
                MessageBox.Show("Modificación exitosa.");
                funLimpiar();
            }
            actualizarCliente();
        }

		private void btnEliminar_Click(object sender, EventArgs e)
		{
            if (txtID.Text == "" && txtNit.Text == "" && txtNombre.Text == "" && txtApellido.Text == "" && txtDireccion.Text == "" && txtTelefono.Text == "")
            {
                MessageBox.Show("No se puede buscar un registro para eliminar.");
            }
            else
            {
                cn.llamarElimCliente(txtID.Text);
                MessageBox.Show("Registro eliminado.");
                funLimpiar();
            }
            actualizarCliente();
        }

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
            txtID.Text = "";
            txtNit.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            estado = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
        }

        private void funLimpiar()
        {
            txtID.Text = "";
            txtNit.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            estado = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
        }
        string tabla1 = "cliente";
        public void actualizarCliente()
        {
            DataTable dt = cn.llenarCliente(tabla1);
            dgvCliente.DataSource = dt;
        }

		private void dgvCliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
            try
            {
                txtID.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
                txtNit.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
                txtTelefono.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
                estado = dgvCliente.CurrentRow.Cells[6].Value.ToString();

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
