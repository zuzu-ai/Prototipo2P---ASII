using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
	public partial class MDIPrincipal : Form
	{
		public MDIPrincipal()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;

		}

		private void MDIPrincipal_Load(object sender, EventArgs e)
		{

		}

		private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Empleado newMDIChild = new Empleado();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Cliente newMDIChild = new Cliente();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Inventario newMDIChild = new Inventario();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Factura newMDIChild = new Factura();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}
	}
}
