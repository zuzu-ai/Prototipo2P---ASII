
namespace P2
{
	partial class Cliente
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
			this.cliente1 = new CapaVista.Cliente();
			this.SuspendLayout();
			// 
			// cliente1
			// 
			this.cliente1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cliente1.BackgroundImage")));
			this.cliente1.Location = new System.Drawing.Point(-2, 0);
			this.cliente1.Name = "cliente1";
			this.cliente1.Size = new System.Drawing.Size(1111, 584);
			this.cliente1.TabIndex = 0;
			// 
			// Cliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cliente1);
			this.Name = "Cliente";
			this.Text = "Cliente";
			this.Load += new System.EventHandler(this.Cliente_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private CapaVista.Cliente cliente1;
	}
}