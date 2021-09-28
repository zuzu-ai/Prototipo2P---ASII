
namespace CapaVista
{
    partial class Factura
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvDetalles = new System.Windows.Forms.DataGridView();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.gbEstado = new System.Windows.Forms.GroupBox();
			this.rbInactivo = new System.Windows.Forms.RadioButton();
			this.rbActivo = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxCliente = new System.Windows.Forms.ComboBox();
			this.lblNit = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblIdCliente = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.txtIdDetalle = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbxProducto = new System.Windows.Forms.ComboBox();
			this.lblIdProducto = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.dgvFacturaE = new System.Windows.Forms.DataGridView();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardarEncabezado = new System.Windows.Forms.Button();
			this.btnLimparG = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnLimparD = new System.Windows.Forms.Button();
			this.btnCancelarD = new System.Windows.Forms.Button();
			this.dgvFacturaD = new System.Windows.Forms.DataGridView();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
			this.gbEstado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFacturaE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFacturaD)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDetalles
			// 
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetalles.Location = new System.Drawing.Point(441, 83);
			this.dgvDetalles.Name = "dgvDetalles";
			this.dgvDetalles.Size = new System.Drawing.Size(443, 492);
			this.dgvDetalles.TabIndex = 18;
			// 
			// txtTotal
			// 
			this.txtTotal.Enabled = false;
			this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(140, 271);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(218, 27);
			this.txtTotal.TabIndex = 15;
			// 
			// txtFecha
			// 
			this.txtFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFecha.Location = new System.Drawing.Point(367, 217);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(218, 27);
			this.txtFecha.TabIndex = 16;
			this.txtFecha.Visible = false;
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(140, 83);
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
			this.gbEstado.Location = new System.Drawing.Point(48, 303);
			this.gbEstado.Name = "gbEstado";
			this.gbEstado.Size = new System.Drawing.Size(357, 75);
			this.gbEstado.TabIndex = 11;
			this.gbEstado.TabStop = false;
			this.gbEstado.Text = "Estado";
			// 
			// rbInactivo
			// 
			this.rbInactivo.AutoSize = true;
			this.rbInactivo.BackColor = System.Drawing.Color.Transparent;
			this.rbInactivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbInactivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.rbInactivo.Location = new System.Drawing.Point(201, 37);
			this.rbInactivo.Name = "rbInactivo";
			this.rbInactivo.Size = new System.Drawing.Size(94, 25);
			this.rbInactivo.TabIndex = 0;
			this.rbInactivo.TabStop = true;
			this.rbInactivo.Text = "Inactivo";
			this.rbInactivo.UseVisualStyleBackColor = false;
			this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
			// 
			// rbActivo
			// 
			this.rbActivo.AutoSize = true;
			this.rbActivo.BackColor = System.Drawing.Color.Transparent;
			this.rbActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.rbActivo.Location = new System.Drawing.Point(37, 36);
			this.rbActivo.Name = "rbActivo";
			this.rbActivo.Size = new System.Drawing.Size(81, 25);
			this.rbActivo.TabIndex = 0;
			this.rbActivo.TabStop = true;
			this.rbActivo.Text = "Acitvo";
			this.rbActivo.UseVisualStyleBackColor = false;
			this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(44, 271);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 21);
			this.label5.TabIndex = 6;
			this.label5.Text = "Total:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(44, 217);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "Fecha:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(44, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 21);
			this.label3.TabIndex = 8;
			this.label3.Text = "Cliente:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(44, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 21);
			this.label2.TabIndex = 9;
			this.label2.Text = "ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(592, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 21);
			this.label1.TabIndex = 10;
			this.label1.Text = "Facturación";
			// 
			// cbxCliente
			// 
			this.cbxCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCliente.FormattingEnabled = true;
			this.cbxCliente.Location = new System.Drawing.Point(140, 125);
			this.cbxCliente.Name = "cbxCliente";
			this.cbxCliente.Size = new System.Drawing.Size(218, 29);
			this.cbxCliente.TabIndex = 19;
			this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
			// 
			// lblNit
			// 
			this.lblNit.AutoSize = true;
			this.lblNit.BackColor = System.Drawing.Color.Transparent;
			this.lblNit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblNit.Location = new System.Drawing.Point(136, 176);
			this.lblNit.Name = "lblNit";
			this.lblNit.Size = new System.Drawing.Size(0, 21);
			this.lblNit.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Location = new System.Drawing.Point(44, 176);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 21);
			this.label8.TabIndex = 20;
			this.label8.Text = "Nit:";
			// 
			// lblIdCliente
			// 
			this.lblIdCliente.AutoSize = true;
			this.lblIdCliente.Location = new System.Drawing.Point(364, 133);
			this.lblIdCliente.Name = "lblIdCliente";
			this.lblIdCliente.Size = new System.Drawing.Size(0, 13);
			this.lblIdCliente.TabIndex = 21;
			this.lblIdCliente.Visible = false;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Location = new System.Drawing.Point(140, 216);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(218, 27);
			this.dtpFecha.TabIndex = 22;
			this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(44, 465);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 21);
			this.label6.TabIndex = 6;
			this.label6.Text = "ID Detalle:";
			// 
			// txtIdDetalle
			// 
			this.txtIdDetalle.Enabled = false;
			this.txtIdDetalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdDetalle.Location = new System.Drawing.Point(140, 465);
			this.txtIdDetalle.Name = "txtIdDetalle";
			this.txtIdDetalle.Size = new System.Drawing.Size(218, 27);
			this.txtIdDetalle.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(44, 507);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 21);
			this.label7.TabIndex = 6;
			this.label7.Text = "Producto:";
			// 
			// cbxProducto
			// 
			this.cbxProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxProducto.FormattingEnabled = true;
			this.cbxProducto.Location = new System.Drawing.Point(140, 507);
			this.cbxProducto.Name = "cbxProducto";
			this.cbxProducto.Size = new System.Drawing.Size(218, 29);
			this.cbxProducto.TabIndex = 19;
			this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
			// 
			// lblIdProducto
			// 
			this.lblIdProducto.AutoSize = true;
			this.lblIdProducto.Location = new System.Drawing.Point(364, 479);
			this.lblIdProducto.Name = "lblIdProducto";
			this.lblIdProducto.Size = new System.Drawing.Size(0, 13);
			this.lblIdProducto.TabIndex = 23;
			this.lblIdProducto.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label9.Location = new System.Drawing.Point(44, 554);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(61, 21);
			this.label9.TabIndex = 6;
			this.label9.Text = "Precio:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Enabled = false;
			this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.Location = new System.Drawing.Point(140, 548);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(218, 27);
			this.txtPrecio.TabIndex = 15;
			// 
			// dgvFacturaE
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvFacturaE.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvFacturaE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFacturaE.Location = new System.Drawing.Point(904, 83);
			this.dgvFacturaE.Name = "dgvFacturaE";
			this.dgvFacturaE.Size = new System.Drawing.Size(433, 229);
			this.dgvFacturaE.TabIndex = 18;
			this.dgvFacturaE.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFacturaE_RowHeaderMouseClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
			this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
			this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimpiar.FlatAppearance.BorderSize = 0;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Location = new System.Drawing.Point(192, 395);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(51, 50);
			this.btnLimpiar.TabIndex = 24;
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
			this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Location = new System.Drawing.Point(249, 395);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(51, 50);
			this.btnCancelar.TabIndex = 26;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardarEncabezado
			// 
			this.btnGuardarEncabezado.BackColor = System.Drawing.Color.Transparent;
			this.btnGuardarEncabezado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarEncabezado.BackgroundImage")));
			this.btnGuardarEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGuardarEncabezado.FlatAppearance.BorderSize = 0;
			this.btnGuardarEncabezado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardarEncabezado.Location = new System.Drawing.Point(135, 395);
			this.btnGuardarEncabezado.Name = "btnGuardarEncabezado";
			this.btnGuardarEncabezado.Size = new System.Drawing.Size(51, 50);
			this.btnGuardarEncabezado.TabIndex = 27;
			this.btnGuardarEncabezado.UseVisualStyleBackColor = false;
			this.btnGuardarEncabezado.Click += new System.EventHandler(this.btnGuardarEncabezado_Click);
			// 
			// btnLimparG
			// 
			this.btnLimparG.BackColor = System.Drawing.Color.Transparent;
			this.btnLimparG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimparG.BackgroundImage")));
			this.btnLimparG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimparG.FlatAppearance.BorderSize = 0;
			this.btnLimparG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimparG.Location = new System.Drawing.Point(673, 593);
			this.btnLimparG.Name = "btnLimparG";
			this.btnLimparG.Size = new System.Drawing.Size(51, 50);
			this.btnLimparG.TabIndex = 28;
			this.btnLimparG.UseVisualStyleBackColor = false;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
			this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
			this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Location = new System.Drawing.Point(616, 593);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(51, 50);
			this.btnGuardar.TabIndex = 31;
			this.btnGuardar.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(135, 593);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(51, 50);
			this.button3.TabIndex = 28;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnLimparD
			// 
			this.btnLimparD.BackColor = System.Drawing.Color.Transparent;
			this.btnLimparD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimparD.BackgroundImage")));
			this.btnLimparD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimparD.FlatAppearance.BorderSize = 0;
			this.btnLimparD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimparD.Location = new System.Drawing.Point(192, 593);
			this.btnLimparD.Name = "btnLimparD";
			this.btnLimparD.Size = new System.Drawing.Size(51, 50);
			this.btnLimparD.TabIndex = 28;
			this.btnLimparD.UseVisualStyleBackColor = false;
			// 
			// btnCancelarD
			// 
			this.btnCancelarD.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelarD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarD.BackgroundImage")));
			this.btnCancelarD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCancelarD.FlatAppearance.BorderSize = 0;
			this.btnCancelarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelarD.Location = new System.Drawing.Point(249, 593);
			this.btnCancelarD.Name = "btnCancelarD";
			this.btnCancelarD.Size = new System.Drawing.Size(51, 50);
			this.btnCancelarD.TabIndex = 26;
			this.btnCancelarD.UseVisualStyleBackColor = false;
			// 
			// dgvFacturaD
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvFacturaD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvFacturaD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFacturaD.Location = new System.Drawing.Point(904, 339);
			this.dgvFacturaD.Name = "dgvFacturaD";
			this.dgvFacturaD.Size = new System.Drawing.Size(433, 236);
			this.dgvFacturaD.TabIndex = 32;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label10.Location = new System.Drawing.Point(1053, 59);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(116, 21);
			this.label10.TabIndex = 33;
			this.label10.Text = "Encabezados";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label11.Location = new System.Drawing.Point(1097, 315);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 21);
			this.label11.TabIndex = 34;
			this.label11.Text = "Detalles";
			// 
			// Factura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CapaVista.Properties.Resources.FondoFRM;
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dgvFacturaD);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnLimparD);
			this.Controls.Add(this.btnLimparG);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCancelarD);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardarEncabezado);
			this.Controls.Add(this.lblIdProducto);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.lblIdCliente);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblNit);
			this.Controls.Add(this.cbxProducto);
			this.Controls.Add(this.cbxCliente);
			this.Controls.Add(this.dgvFacturaE);
			this.Controls.Add(this.dgvDetalles);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtIdDetalle);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtFecha);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.gbEstado);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Factura";
			this.Size = new System.Drawing.Size(1358, 663);
			this.Load += new System.EventHandler(this.Factura_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
			this.gbEstado.ResumeLayout(false);
			this.gbEstado.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFacturaE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFacturaD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridView dgvFacturaE;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarEncabezado;
        private System.Windows.Forms.Button btnLimparG;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLimparD;
        private System.Windows.Forms.Button btnCancelarD;
		private System.Windows.Forms.DataGridView dgvFacturaD;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
	}
}
