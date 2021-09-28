
namespace CapaVista
{
    partial class EjemploMantenimiento
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjemploMantenimiento));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.gbEstado = new System.Windows.Forms.GroupBox();
			this.rbInactivo = new System.Windows.Forms.RadioButton();
			this.rbActivo = new System.Windows.Forms.RadioButton();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtDPI = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.dgvEmpleado = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.gbEstado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(465, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Empleado";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(45, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "ID:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(45, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "DPI:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(45, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 21);
			this.label4.TabIndex = 0;
			this.label4.Text = "Nombre:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(45, 218);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 21);
			this.label5.TabIndex = 0;
			this.label5.Text = "Apellido:";
			// 
			// gbEstado
			// 
			this.gbEstado.BackColor = System.Drawing.Color.Transparent;
			this.gbEstado.Controls.Add(this.rbInactivo);
			this.gbEstado.Controls.Add(this.rbActivo);
			this.gbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.gbEstado.Location = new System.Drawing.Point(48, 351);
			this.gbEstado.Name = "gbEstado";
			this.gbEstado.Size = new System.Drawing.Size(318, 100);
			this.gbEstado.TabIndex = 1;
			this.gbEstado.TabStop = false;
			this.gbEstado.Text = "Estado";
			// 
			// rbInactivo
			// 
			this.rbInactivo.AutoSize = true;
			this.rbInactivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbInactivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.rbInactivo.Location = new System.Drawing.Point(167, 36);
			this.rbInactivo.Name = "rbInactivo";
			this.rbInactivo.Size = new System.Drawing.Size(94, 25);
			this.rbInactivo.TabIndex = 0;
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
			this.rbActivo.Text = "Acitvo";
			this.rbActivo.UseVisualStyleBackColor = true;
			this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(148, 65);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(218, 27);
			this.txtID.TabIndex = 2;
			// 
			// txtDPI
			// 
			this.txtDPI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDPI.Location = new System.Drawing.Point(148, 110);
			this.txtDPI.Name = "txtDPI";
			this.txtDPI.Size = new System.Drawing.Size(218, 27);
			this.txtDPI.TabIndex = 2;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(148, 158);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(218, 27);
			this.txtNombre.TabIndex = 2;
			// 
			// txtApellido
			// 
			this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellido.Location = new System.Drawing.Point(148, 208);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(218, 27);
			this.txtApellido.TabIndex = 2;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDireccion.Location = new System.Drawing.Point(148, 258);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(218, 27);
			this.txtDireccion.TabIndex = 2;
			// 
			// dgvEmpleado
			// 
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvEmpleado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvEmpleado.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvEmpleado.Location = new System.Drawing.Point(407, 68);
			this.dgvEmpleado.Name = "dgvEmpleado";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvEmpleado.Size = new System.Drawing.Size(614, 459);
			this.dgvEmpleado.TabIndex = 3;
			this.dgvEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellContentClick);
			this.dgvEmpleado.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpleado_RowHeaderMouseClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(45, 264);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 21);
			this.label6.TabIndex = 0;
			this.label6.Text = "Dirección:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(45, 307);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 21);
			this.label7.TabIndex = 0;
			this.label7.Text = "Teléfono";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(148, 301);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(218, 27);
			this.txtTelefono.TabIndex = 2;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
			this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
			this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimpiar.FlatAppearance.BorderSize = 0;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Location = new System.Drawing.Point(287, 477);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(51, 50);
			this.btnLimpiar.TabIndex = 5;
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
			this.btnEliminar.Location = new System.Drawing.Point(219, 477);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(51, 50);
			this.btnEliminar.TabIndex = 6;
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
			this.btnModificar.Location = new System.Drawing.Point(148, 477);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(51, 50);
			this.btnModificar.TabIndex = 7;
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
			this.btnInsertar.Location = new System.Drawing.Point(71, 477);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(51, 50);
			this.btnInsertar.TabIndex = 8;
			this.btnInsertar.UseVisualStyleBackColor = false;
			this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
			// 
			// EjemploMantenimiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CapaVista.Properties.Resources.FondoFRM;
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.txtDPI);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.gbEstado);
			this.Controls.Add(this.btnInsertar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.dgvEmpleado);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "EjemploMantenimiento";
			this.Size = new System.Drawing.Size(1060, 571);
			this.gbEstado.ResumeLayout(false);
			this.gbEstado.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
	}
}
