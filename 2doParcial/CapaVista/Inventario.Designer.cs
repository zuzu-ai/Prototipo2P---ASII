
namespace CapaVista
{
    partial class Inventario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
			this.dgvProducto = new System.Windows.Forms.DataGridView();
			this.txtExistencias = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.gbEstado = new System.Windows.Forms.GroupBox();
			this.rbInactivo = new System.Windows.Forms.RadioButton();
			this.rbActivo = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnInsertar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
			this.gbEstado.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvProducto
			// 
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducto.Location = new System.Drawing.Point(424, 78);
			this.dgvProducto.Name = "dgvProducto";
			this.dgvProducto.Size = new System.Drawing.Size(579, 416);
			this.dgvProducto.TabIndex = 18;
			this.dgvProducto.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducto_RowHeaderMouseClick);
			// 
			// txtExistencias
			// 
			this.txtExistencias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExistencias.Location = new System.Drawing.Point(182, 271);
			this.txtExistencias.Name = "txtExistencias";
			this.txtExistencias.Size = new System.Drawing.Size(218, 27);
			this.txtExistencias.TabIndex = 13;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.Location = new System.Drawing.Point(182, 221);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(218, 27);
			this.txtPrecio.TabIndex = 14;
			// 
			// txtCosto
			// 
			this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCosto.Location = new System.Drawing.Point(182, 171);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(218, 27);
			this.txtCosto.TabIndex = 15;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(182, 123);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(218, 27);
			this.txtNombre.TabIndex = 16;
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(182, 78);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(218, 27);
			this.txtID.TabIndex = 17;
			// 
			// gbEstado
			// 
			this.gbEstado.BackColor = System.Drawing.Color.Transparent;
			this.gbEstado.Controls.Add(this.rbInactivo);
			this.gbEstado.Controls.Add(this.rbActivo);
			this.gbEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.gbEstado.Location = new System.Drawing.Point(31, 327);
			this.gbEstado.Name = "gbEstado";
			this.gbEstado.Size = new System.Drawing.Size(357, 100);
			this.gbEstado.TabIndex = 11;
			this.gbEstado.TabStop = false;
			this.gbEstado.Text = "Estado";
			// 
			// rbInactivo
			// 
			this.rbInactivo.AutoSize = true;
			this.rbInactivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbInactivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.rbInactivo.Location = new System.Drawing.Point(201, 37);
			this.rbInactivo.Name = "rbInactivo";
			this.rbInactivo.Size = new System.Drawing.Size(94, 25);
			this.rbInactivo.TabIndex = 0;
			this.rbInactivo.TabStop = true;
			this.rbInactivo.Text = "Inactivo";
			this.rbInactivo.UseVisualStyleBackColor = true;
			this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
			// 
			// rbActivo
			// 
			this.rbActivo.AutoSize = true;
			this.rbActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.rbActivo.Location = new System.Drawing.Point(37, 36);
			this.rbActivo.Name = "rbActivo";
			this.rbActivo.Size = new System.Drawing.Size(81, 25);
			this.rbActivo.TabIndex = 0;
			this.rbActivo.TabStop = true;
			this.rbActivo.Text = "Acitvo";
			this.rbActivo.UseVisualStyleBackColor = true;
			this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(27, 274);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 21);
			this.label6.TabIndex = 5;
			this.label6.Text = "Existencias:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(27, 228);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 21);
			this.label5.TabIndex = 6;
			this.label5.Text = "Precio de Venta:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(27, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "Costo:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(27, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(153, 21);
			this.label3.TabIndex = 8;
			this.label3.Text = "Nombre Producto:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(27, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 21);
			this.label2.TabIndex = 9;
			this.label2.Text = "ID:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(447, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 21);
			this.label1.TabIndex = 10;
			this.label1.Text = "Producto";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
			this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
			this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimpiar.FlatAppearance.BorderSize = 0;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Location = new System.Drawing.Point(292, 444);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(51, 50);
			this.btnLimpiar.TabIndex = 19;
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
			this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(224, 444);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(51, 50);
			this.btnEliminar.TabIndex = 20;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.Transparent;
			this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
			this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnModificar.FlatAppearance.BorderSize = 0;
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.Location = new System.Drawing.Point(153, 444);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(51, 50);
			this.btnModificar.TabIndex = 21;
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnInsertar
			// 
			this.btnInsertar.BackColor = System.Drawing.Color.Transparent;
			this.btnInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertar.BackgroundImage")));
			this.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnInsertar.FlatAppearance.BorderSize = 0;
			this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsertar.Location = new System.Drawing.Point(78, 444);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(51, 50);
			this.btnInsertar.TabIndex = 22;
			this.btnInsertar.UseVisualStyleBackColor = false;
			this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
			// 
			// Inventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CapaVista.Properties.Resources.FondoFRM;
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCosto);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtExistencias);
			this.Controls.Add(this.gbEstado);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnInsertar);
			this.Controls.Add(this.dgvProducto);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Inventario";
			this.Size = new System.Drawing.Size(1045, 532);
			((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
			this.gbEstado.ResumeLayout(false);
			this.gbEstado.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
	}
}
