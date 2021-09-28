
namespace P2
{
	partial class Factura
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
			this.factura1 = new CapaVista.Factura();
			this.SuspendLayout();
			// 
			// factura1
			// 
			this.factura1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("factura1.BackgroundImage")));
			this.factura1.Location = new System.Drawing.Point(-1, 0);
			this.factura1.Name = "factura1";
			this.factura1.Size = new System.Drawing.Size(1358, 663);
			this.factura1.TabIndex = 0;
			this.factura1.Load += new System.EventHandler(this.factura1_Load);
			// 
			// Factura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.factura1);
			this.Name = "Factura";
			this.Text = "Factura";
			this.ResumeLayout(false);

		}

		#endregion

		private CapaVista.Factura factura1;
	}
}