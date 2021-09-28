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
    public partial class EjemploMantenimientoCombo : UserControl
    {
		Controlador cn = new Controlador();
        string estado = "0";
        public EjemploMantenimientoCombo()
        {
            InitializeComponent();
			llenarcbxIdEmpleado();
            actualizarUsuario();
            funLimpiar();
        }
        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            estado = "1";
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            estado = "0";
        }
        public void llenarcbxIdEmpleado()
		{
			try
			{
				cbxIdEmpleado.Items.Clear();
				OdbcDataReader datareader = cn.llenarcbxEmpleado();
				cbxIdEmpleado.Items.Add("Selecione un Empleado");
				while (datareader.Read())
				{
					cbxIdEmpleado.Items.Add(datareader[0].ToString());
				}
				cbxIdEmpleado.SelectedIndex = 0;
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}
		public string consultaIdEmpleado(string nombre)
		{
			string id_empleado = cn.consultaIdEmpleado(nombre);
			return id_empleado;
		}

        private void cbxIdEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
			lblIdEmpleado.Text = consultaIdEmpleado(cbxIdEmpleado.Text);
        }
        string tabla1 = "usuario";
        public void actualizarUsuario()
        {
            DataTable dt = cn.llenarEmpleado(tabla1);
            dgUsuario.DataSource = dt;
        }
        private void dgUsuario_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
        public void funLimpiar()
        {
            txtIdUsuario.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            llenarcbxIdEmpleado();
            estado = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "" && cbxIdEmpleado.SelectedIndex==0 && txtUsuario.Text == "" && txtContraseña.Text == "" && estado=="")
            {
                MessageBox.Show("Una o más casillas están vacías.");
            }
            else
            {
                cn.llamarInsertUsurio(txtIdUsuario.Text, lblIdEmpleado.Text, txtUsuario.Text, txtContraseña.Text, estado);
                MessageBox.Show("Ingreso exitoso.");
                funLimpiar();
            }
            actualizarUsuario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "" && cbxIdEmpleado.SelectedIndex == 0 && txtUsuario.Text == "" && txtContraseña.Text == "" )
            {
                MessageBox.Show("Debe llenar las casillas para modificar el registro.");
            }
            else
            {
                cn.llamarModifUsuario(txtIdUsuario.Text, cbxIdEmpleado.Text, txtUsuario.Text, txtContraseña.Text, estado);
                MessageBox.Show("Modificación exitosa.");
                funLimpiar();
            }
            actualizarUsuario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "" && cbxIdEmpleado.SelectedIndex == 0 && txtUsuario.Text == "" && txtContraseña.Text == "")
            {
                MessageBox.Show("No se puede buscar un registro para eliminar.");
            }
            else
            {
                cn.llamarElimEmpleado(txtIdUsuario.Text);
                MessageBox.Show("Registro eliminado.");
                funLimpiar();
            }
            actualizarUsuario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            funLimpiar();
        }

        private void dgUsuario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtIdUsuario.Text = dgUsuario.CurrentRow.Cells[0].Value.ToString();
                cbxIdEmpleado.Text = dgUsuario.CurrentRow.Cells[1].Value.ToString();
                txtUsuario.Text = dgUsuario.CurrentRow.Cells[2].Value.ToString();
                txtContraseña.Text = dgUsuario.CurrentRow.Cells[3].Value.ToString();
                estado = dgUsuario.CurrentRow.Cells[4].Value.ToString();

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
    }
}
