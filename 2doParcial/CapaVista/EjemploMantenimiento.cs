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
    public partial class EjemploMantenimiento : UserControl
    {
        Controlador cn = new Controlador();
        string estado = "";
        public EjemploMantenimiento()
        {
            InitializeComponent();
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
            actualizarEmpleado();
            funLimpiar();
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtID.Text=="" && txtDPI.Text=="" && txtNombre.Text=="" && txtApellido.Text=="" && txtDireccion.Text=="" && txtTelefono.Text == "")
            {
                MessageBox.Show("Una o más casillas están vacías.");
            }
            else
            {
                cn.llamarInsertEmpleado(txtID.Text, txtDPI.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, estado);
                MessageBox.Show("Ingreso exitoso.");
                funLimpiar();
            }
            actualizarEmpleado();
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
                estado = "1";
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
                estado = "0";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" && txtDPI.Text == "" && txtNombre.Text == "" && txtApellido.Text == "" && txtDireccion.Text == "" && txtTelefono.Text == "") 
            {
                MessageBox.Show("Debe llenar las casillas para modificar el registro.");
            }
            else
            {
                cn.llamarModifEmpleado(txtID.Text, txtDPI.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, estado);
                MessageBox.Show("Modificación exitosa.");
                funLimpiar();
            }
            actualizarEmpleado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" && txtDPI.Text == "" && txtNombre.Text == "" && txtApellido.Text == "" && txtDireccion.Text == "" && txtTelefono.Text == "")
            {
                MessageBox.Show("No se puede buscar un registro para eliminar.");
            }
            else
            {
                cn.llamarElimEmpleado(txtID.Text);
                MessageBox.Show("Registro eliminado.");
                funLimpiar();
            }
            actualizarEmpleado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtDPI.Text = "";
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
            txtDPI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            estado = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
        }
        string tabla1 = "empleado";
        public void actualizarEmpleado()
        {
            DataTable dt = cn.llenarEmpleado(tabla1);
            dgvEmpleado.DataSource = dt;
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvEmpleado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtID.Text = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();
                txtDPI.Text = dgvEmpleado.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvEmpleado.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = dgvEmpleado.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgvEmpleado.CurrentRow.Cells[4].Value.ToString();
                txtTelefono.Text = dgvEmpleado.CurrentRow.Cells[5].Value.ToString();
                estado = dgvEmpleado.CurrentRow.Cells[6].Value.ToString();

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
	}
}
