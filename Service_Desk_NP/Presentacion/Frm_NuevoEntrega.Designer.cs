namespace Presentacion
{
    partial class Frm_NuevoEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NuevoEntrega));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gpbBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.cmbFiltrado = new System.Windows.Forms.ComboBox();
            this.lblFiltrado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpbTablaCliente = new System.Windows.Forms.GroupBox();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.gpbDatosEntrega = new System.Windows.Forms.GroupBox();
            this.lblNoTicket = new System.Windows.Forms.Label();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.txtRepuesto = new System.Windows.Forms.TextBox();
            this.lblTrabajoRealizado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtTrabajo = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTecnicoAsignado = new System.Windows.Forms.Label();
            this.lblNoSerie = new System.Windows.Forms.Label();
            this.gpbBusqueda.SuspendLayout();
            this.gpbTablaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            this.gpbDatosEntrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(586, 551);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(156, 33);
            this.btnImprimir.TabIndex = 112;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(748, 551);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 33);
            this.btnGuardar.TabIndex = 113;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(352, 551);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 33);
            this.btnEliminar.TabIndex = 111;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gpbBusqueda
            // 
            this.gpbBusqueda.Controls.Add(this.txtBusqueda);
            this.gpbBusqueda.Controls.Add(this.lblBusqueda);
            this.gpbBusqueda.Controls.Add(this.cmbFiltrado);
            this.gpbBusqueda.Controls.Add(this.lblFiltrado);
            this.gpbBusqueda.Controls.Add(this.btnBuscar);
            this.gpbBusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusqueda.ForeColor = System.Drawing.Color.White;
            this.gpbBusqueda.Location = new System.Drawing.Point(525, 12);
            this.gpbBusqueda.Name = "gpbBusqueda";
            this.gpbBusqueda.Size = new System.Drawing.Size(363, 103);
            this.gpbBusqueda.TabIndex = 114;
            this.gpbBusqueda.TabStop = false;
            this.gpbBusqueda.Text = "BUSQUEDA";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(152, 58);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(128, 23);
            this.txtBusqueda.TabIndex = 7;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblBusqueda.Location = new System.Drawing.Point(17, 65);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(77, 16);
            this.lblBusqueda.TabIndex = 6;
            this.lblBusqueda.Text = "Búsqueda:";
            // 
            // cmbFiltrado
            // 
            this.cmbFiltrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrado.FormattingEnabled = true;
            this.cmbFiltrado.Location = new System.Drawing.Point(152, 30);
            this.cmbFiltrado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltrado.Name = "cmbFiltrado";
            this.cmbFiltrado.Size = new System.Drawing.Size(128, 24);
            this.cmbFiltrado.TabIndex = 9;
            // 
            // lblFiltrado
            // 
            this.lblFiltrado.AutoSize = true;
            this.lblFiltrado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrado.ForeColor = System.Drawing.Color.White;
            this.lblFiltrado.Location = new System.Drawing.Point(17, 38);
            this.lblFiltrado.Name = "lblFiltrado";
            this.lblFiltrado.Size = new System.Drawing.Size(82, 16);
            this.lblFiltrado.TabIndex = 8;
            this.lblFiltrado.Text = "Buscar por:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.Location = new System.Drawing.Point(284, 58);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseCompatibleTextRendering = true;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(206, 551);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 33);
            this.btnEditar.TabIndex = 110;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gpbTablaCliente
            // 
            this.gpbTablaCliente.Controls.Add(this.dgvEntregas);
            this.gpbTablaCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTablaCliente.ForeColor = System.Drawing.Color.White;
            this.gpbTablaCliente.Location = new System.Drawing.Point(12, 12);
            this.gpbTablaCliente.Name = "gpbTablaCliente";
            this.gpbTablaCliente.Size = new System.Drawing.Size(480, 533);
            this.gpbTablaCliente.TabIndex = 115;
            this.gpbTablaCliente.TabStop = false;
            this.gpbTablaCliente.Text = "ENTREGAS";
            this.gpbTablaCliente.Enter += new System.EventHandler(this.gpbTablaCliente_Enter);
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEntregas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEntregas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(247)))), ((int)(((byte)(235)))));
            this.dgvEntregas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntregas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvEntregas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntregas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEntregas.ColumnHeadersHeight = 25;
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntregas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEntregas.EnableHeadersVisualStyles = false;
            this.dgvEntregas.GridColor = System.Drawing.Color.Turquoise;
            this.dgvEntregas.Location = new System.Drawing.Point(6, 30);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(247)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntregas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEntregas.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(247)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEntregas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEntregas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntregas.Size = new System.Drawing.Size(468, 497);
            this.dgvEntregas.TabIndex = 1;
            // 
            // gpbDatosEntrega
            // 
            this.gpbDatosEntrega.Controls.Add(this.lblNoTicket);
            this.gpbDatosEntrega.Controls.Add(this.txtTicket);
            this.gpbDatosEntrega.Controls.Add(this.lblGarantia);
            this.gpbDatosEntrega.Controls.Add(this.txtGarantia);
            this.gpbDatosEntrega.Controls.Add(this.dtFecha);
            this.gpbDatosEntrega.Controls.Add(this.cmbEstado);
            this.gpbDatosEntrega.Controls.Add(this.txtCliente);
            this.gpbDatosEntrega.Controls.Add(this.txtSerie);
            this.gpbDatosEntrega.Controls.Add(this.txtTecnico);
            this.gpbDatosEntrega.Controls.Add(this.lblRepuesto);
            this.gpbDatosEntrega.Controls.Add(this.lblFechaEntrega);
            this.gpbDatosEntrega.Controls.Add(this.txtRepuesto);
            this.gpbDatosEntrega.Controls.Add(this.lblTrabajoRealizado);
            this.gpbDatosEntrega.Controls.Add(this.lblEstado);
            this.gpbDatosEntrega.Controls.Add(this.txtTrabajo);
            this.gpbDatosEntrega.Controls.Add(this.lblCliente);
            this.gpbDatosEntrega.Controls.Add(this.lblTecnicoAsignado);
            this.gpbDatosEntrega.Controls.Add(this.lblNoSerie);
            this.gpbDatosEntrega.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosEntrega.ForeColor = System.Drawing.Color.White;
            this.gpbDatosEntrega.Location = new System.Drawing.Point(525, 146);
            this.gpbDatosEntrega.Name = "gpbDatosEntrega";
            this.gpbDatosEntrega.Size = new System.Drawing.Size(363, 399);
            this.gpbDatosEntrega.TabIndex = 116;
            this.gpbDatosEntrega.TabStop = false;
            this.gpbDatosEntrega.Text = "DATOS";
            // 
            // lblNoTicket
            // 
            this.lblNoTicket.AutoSize = true;
            this.lblNoTicket.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTicket.ForeColor = System.Drawing.Color.White;
            this.lblNoTicket.Location = new System.Drawing.Point(17, 48);
            this.lblNoTicket.Name = "lblNoTicket";
            this.lblNoTicket.Size = new System.Drawing.Size(72, 16);
            this.lblNoTicket.TabIndex = 39;
            this.lblNoTicket.Text = "No Ticket:";
            // 
            // txtTicket
            // 
            this.txtTicket.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(151, 41);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(200, 23);
            this.txtTicket.TabIndex = 38;
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantia.ForeColor = System.Drawing.Color.White;
            this.lblGarantia.Location = new System.Drawing.Point(12, 345);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(71, 16);
            this.lblGarantia.TabIndex = 37;
            this.lblGarantia.Text = "Garantia:";
            // 
            // txtGarantia
            // 
            this.txtGarantia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.Location = new System.Drawing.Point(151, 342);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(200, 23);
            this.txtGarantia.TabIndex = 13;
            // 
            // dtFecha
            // 
            this.dtFecha.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Location = new System.Drawing.Point(151, 186);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 23);
            this.dtFecha.TabIndex = 10;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(151, 156);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 24);
            this.cmbEstado.TabIndex = 9;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(151, 70);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(200, 23);
            this.txtCliente.TabIndex = 6;
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(151, 99);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(200, 23);
            this.txtSerie.TabIndex = 7;
            // 
            // txtTecnico
            // 
            this.txtTecnico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTecnico.Location = new System.Drawing.Point(151, 128);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.Size = new System.Drawing.Size(200, 23);
            this.txtTecnico.TabIndex = 8;
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuesto.ForeColor = System.Drawing.Color.White;
            this.lblRepuesto.Location = new System.Drawing.Point(17, 280);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(71, 16);
            this.lblRepuesto.TabIndex = 11;
            this.lblRepuesto.Text = "Repuesto:";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.ForeColor = System.Drawing.Color.White;
            this.lblFechaEntrega.Location = new System.Drawing.Point(17, 193);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(127, 16);
            this.lblFechaEntrega.TabIndex = 8;
            this.lblFechaEntrega.Text = "Fecha de entrega:";
            // 
            // txtRepuesto
            // 
            this.txtRepuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepuesto.Location = new System.Drawing.Point(151, 277);
            this.txtRepuesto.Multiline = true;
            this.txtRepuesto.Name = "txtRepuesto";
            this.txtRepuesto.Size = new System.Drawing.Size(200, 59);
            this.txtRepuesto.TabIndex = 12;
            // 
            // lblTrabajoRealizado
            // 
            this.lblTrabajoRealizado.AutoSize = true;
            this.lblTrabajoRealizado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajoRealizado.ForeColor = System.Drawing.Color.White;
            this.lblTrabajoRealizado.Location = new System.Drawing.Point(17, 229);
            this.lblTrabajoRealizado.Name = "lblTrabajoRealizado";
            this.lblTrabajoRealizado.Size = new System.Drawing.Size(128, 16);
            this.lblTrabajoRealizado.TabIndex = 10;
            this.lblTrabajoRealizado.Text = "Trabajo realizado:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(17, 164);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 16);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // txtTrabajo
            // 
            this.txtTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabajo.Location = new System.Drawing.Point(151, 212);
            this.txtTrabajo.Multiline = true;
            this.txtTrabajo.Name = "txtTrabajo";
            this.txtTrabajo.Size = new System.Drawing.Size(200, 59);
            this.txtTrabajo.TabIndex = 11;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(17, 77);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(80, 16);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "No Cliente:";
            // 
            // lblTecnicoAsignado
            // 
            this.lblTecnicoAsignado.AutoSize = true;
            this.lblTecnicoAsignado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnicoAsignado.ForeColor = System.Drawing.Color.White;
            this.lblTecnicoAsignado.Location = new System.Drawing.Point(17, 135);
            this.lblTecnicoAsignado.Name = "lblTecnicoAsignado";
            this.lblTecnicoAsignado.Size = new System.Drawing.Size(129, 16);
            this.lblTecnicoAsignado.TabIndex = 7;
            this.lblTecnicoAsignado.Text = "Tecnico Asignado:";
            // 
            // lblNoSerie
            // 
            this.lblNoSerie.AutoSize = true;
            this.lblNoSerie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSerie.ForeColor = System.Drawing.Color.White;
            this.lblNoSerie.Location = new System.Drawing.Point(17, 106);
            this.lblNoSerie.Name = "lblNoSerie";
            this.lblNoSerie.Size = new System.Drawing.Size(66, 16);
            this.lblNoSerie.TabIndex = 6;
            this.lblNoSerie.Text = "No Serie:";
            // 
            // Frm_NuevoEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(900, 624);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gpbBusqueda);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gpbTablaCliente);
            this.Controls.Add(this.gpbDatosEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_NuevoEntrega";
            this.Text = "Frm_Entrega";
            this.Load += new System.EventHandler(this.Frm_Entrega_Load);
            this.gpbBusqueda.ResumeLayout(false);
            this.gpbBusqueda.PerformLayout();
            this.gpbTablaCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            this.gpbDatosEntrega.ResumeLayout(false);
            this.gpbDatosEntrega.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gpbBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.ComboBox cmbFiltrado;
        private System.Windows.Forms.Label lblFiltrado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gpbTablaCliente;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.GroupBox gpbDatosEntrega;
        private System.Windows.Forms.Label lblNoTicket;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.Label lblRepuesto;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.TextBox txtRepuesto;
        private System.Windows.Forms.Label lblTrabajoRealizado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtTrabajo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTecnicoAsignado;
        private System.Windows.Forms.Label lblNoSerie;
    }
}