
namespace P2
{
	partial class Inventario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
			this.inventario1 = new CapaVista.Inventario();
			this.SuspendLayout();
			// 
			// inventario1
			// 
			this.inventario1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inventario1.BackgroundImage")));
			this.inventario1.Location = new System.Drawing.Point(0, 1);
			this.inventario1.Name = "inventario1";
			this.inventario1.Size = new System.Drawing.Size(1045, 532);
			this.inventario1.TabIndex = 0;
			this.inventario1.Load += new System.EventHandler(this.inventario1_Load);
			// 
			// Inventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.inventario1);
			this.Name = "Inventario";
			this.Text = "Inventario";
			this.ResumeLayout(false);

		}

		#endregion

		private CapaVista.Inventario inventario1;
	}
}