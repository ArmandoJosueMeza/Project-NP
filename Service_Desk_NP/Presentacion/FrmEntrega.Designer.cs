namespace Service_Desk_NP
{
    partial class FrmEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrega));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gpbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFiltrado = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cmbFiltrado = new System.Windows.Forms.ComboBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpbTablaCliente = new System.Windows.Forms.GroupBox();
            this.gpbDatosEntrega = new System.Windows.Forms.GroupBox();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.dtFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtNoCliente = new System.Windows.Forms.TextBox();
            this.txtNoSerie = new System.Windows.Forms.TextBox();
            this.txtTecnicoAsignado = new System.Windows.Forms.TextBox();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.txtRepuesto = new System.Windows.Forms.TextBox();
            this.lblTrabajoRealizado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtTrabajoRealizado = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTecnicoAsignado = new System.Windows.Forms.Label();
            this.lblNoSerie = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.gpbBusqueda.SuspendLayout();
            this.gpbTablaCliente.SuspendLayout();
            this.gpbDatosEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            this.SuspendLayout();
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
            this.btnGuardar.Location = new System.Drawing.Point(733, 535);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 33);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(860, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 25);
            this.btnCerrar.TabIndex = 105;
            this.btnCerrar.Text = "X";
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
            this.btnEliminar.Location = new System.Drawing.Point(353, 535);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 33);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // gpbBusqueda
            // 
            this.gpbBusqueda.Controls.Add(this.btnBuscar);
            this.gpbBusqueda.Controls.Add(this.lblFiltrado);
            this.gpbBusqueda.Controls.Add(this.txtBusqueda);
            this.gpbBusqueda.Controls.Add(this.cmbFiltrado);
            this.gpbBusqueda.Controls.Add(this.lblBusqueda);
            this.gpbBusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusqueda.ForeColor = System.Drawing.Color.White;
            this.gpbBusqueda.Location = new System.Drawing.Point(510, 64);
            this.gpbBusqueda.Name = "gpbBusqueda";
            this.gpbBusqueda.Size = new System.Drawing.Size(363, 121);
            this.gpbBusqueda.TabIndex = 107;
            this.gpbBusqueda.TabStop = false;
            this.gpbBusqueda.Text = "Busqueda de Entregas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.Location = new System.Drawing.Point(288, 71);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 21);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseCompatibleTextRendering = true;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblFiltrado
            // 
            this.lblFiltrado.AutoSize = true;
            this.lblFiltrado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrado.ForeColor = System.Drawing.Color.White;
            this.lblFiltrado.Location = new System.Drawing.Point(15, 76);
            this.lblFiltrado.Name = "lblFiltrado";
            this.lblFiltrado.Size = new System.Drawing.Size(82, 16);
            this.lblFiltrado.TabIndex = 3;
            this.lblFiltrado.Text = "Buscar por:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(153, 38);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(128, 23);
            this.txtBusqueda.TabIndex = 3;
            // 
            // cmbFiltrado
            // 
            this.cmbFiltrado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrado.FormattingEnabled = true;
            this.cmbFiltrado.Location = new System.Drawing.Point(153, 68);
            this.cmbFiltrado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltrado.Name = "cmbFiltrado";
            this.cmbFiltrado.Size = new System.Drawing.Size(128, 24);
            this.cmbFiltrado.TabIndex = 4;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblBusqueda.Location = new System.Drawing.Point(15, 45);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(77, 16);
            this.lblBusqueda.TabIndex = 2;
            this.lblBusqueda.Text = "Búsqueda:";
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
            this.btnEditar.Location = new System.Drawing.Point(207, 535);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 33);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // gpbTablaCliente
            // 
            this.gpbTablaCliente.Controls.Add(this.dgvEntregas);
            this.gpbTablaCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTablaCliente.ForeColor = System.Drawing.Color.White;
            this.gpbTablaCliente.Location = new System.Drawing.Point(13, 64);
            this.gpbTablaCliente.Name = "gpbTablaCliente";
            this.gpbTablaCliente.Size = new System.Drawing.Size(480, 465);
            this.gpbTablaCliente.TabIndex = 108;
            this.gpbTablaCliente.TabStop = false;
            this.gpbTablaCliente.Text = "Entregas";
            // 
            // gpbDatosEntrega
            // 
            this.gpbDatosEntrega.Controls.Add(this.lblGarantia);
            this.gpbDatosEntrega.Controls.Add(this.txtGarantia);
            this.gpbDatosEntrega.Controls.Add(this.dtFechaEntrega);
            this.gpbDatosEntrega.Controls.Add(this.cmbEstado);
            this.gpbDatosEntrega.Controls.Add(this.txtNoCliente);
            this.gpbDatosEntrega.Controls.Add(this.txtNoSerie);
            this.gpbDatosEntrega.Controls.Add(this.txtTecnicoAsignado);
            this.gpbDatosEntrega.Controls.Add(this.lblRepuesto);
            this.gpbDatosEntrega.Controls.Add(this.lblFechaEntrega);
            this.gpbDatosEntrega.Controls.Add(this.txtRepuesto);
            this.gpbDatosEntrega.Controls.Add(this.lblTrabajoRealizado);
            this.gpbDatosEntrega.Controls.Add(this.lblEstado);
            this.gpbDatosEntrega.Controls.Add(this.txtTrabajoRealizado);
            this.gpbDatosEntrega.Controls.Add(this.lblCliente);
            this.gpbDatosEntrega.Controls.Add(this.lblTecnicoAsignado);
            this.gpbDatosEntrega.Controls.Add(this.lblNoSerie);
            this.gpbDatosEntrega.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosEntrega.ForeColor = System.Drawing.Color.White;
            this.gpbDatosEntrega.Location = new System.Drawing.Point(510, 191);
            this.gpbDatosEntrega.Name = "gpbDatosEntrega";
            this.gpbDatosEntrega.Size = new System.Drawing.Size(363, 338);
            this.gpbDatosEntrega.TabIndex = 109;
            this.gpbDatosEntrega.TabStop = false;
            this.gpbDatosEntrega.Text = "Datos Entrega";
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantia.ForeColor = System.Drawing.Color.White;
            this.lblGarantia.Location = new System.Drawing.Point(15, 307);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(71, 16);
            this.lblGarantia.TabIndex = 37;
            this.lblGarantia.Text = "Garantia:";
            // 
            // txtGarantia
            // 
            this.txtGarantia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.Location = new System.Drawing.Point(151, 300);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(200, 23);
            this.txtGarantia.TabIndex = 13;
            // 
            // dtFechaEntrega
            // 
            this.dtFechaEntrega.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaEntrega.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaEntrega.Location = new System.Drawing.Point(151, 142);
            this.dtFechaEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaEntrega.Name = "dtFechaEntrega";
            this.dtFechaEntrega.Size = new System.Drawing.Size(200, 23);
            this.dtFechaEntrega.TabIndex = 10;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(151, 114);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 24);
            this.cmbEstado.TabIndex = 9;
            // 
            // txtNoCliente
            // 
            this.txtNoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoCliente.Location = new System.Drawing.Point(151, 28);
            this.txtNoCliente.Name = "txtNoCliente";
            this.txtNoCliente.Size = new System.Drawing.Size(200, 23);
            this.txtNoCliente.TabIndex = 6;
            // 
            // txtNoSerie
            // 
            this.txtNoSerie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoSerie.Location = new System.Drawing.Point(151, 57);
            this.txtNoSerie.Name = "txtNoSerie";
            this.txtNoSerie.Size = new System.Drawing.Size(200, 23);
            this.txtNoSerie.TabIndex = 7;
            // 
            // txtTecnicoAsignado
            // 
            this.txtTecnicoAsignado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTecnicoAsignado.Location = new System.Drawing.Point(151, 86);
            this.txtTecnicoAsignado.Name = "txtTecnicoAsignado";
            this.txtTecnicoAsignado.Size = new System.Drawing.Size(200, 23);
            this.txtTecnicoAsignado.TabIndex = 8;
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuesto.ForeColor = System.Drawing.Color.White;
            this.lblRepuesto.Location = new System.Drawing.Point(15, 238);
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
            this.lblFechaEntrega.Location = new System.Drawing.Point(15, 149);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(127, 16);
            this.lblFechaEntrega.TabIndex = 8;
            this.lblFechaEntrega.Text = "Fecha de entrega:";
            // 
            // txtRepuesto
            // 
            this.txtRepuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepuesto.Location = new System.Drawing.Point(151, 235);
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
            this.lblTrabajoRealizado.Location = new System.Drawing.Point(15, 182);
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
            this.lblEstado.Location = new System.Drawing.Point(17, 122);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 16);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // txtTrabajoRealizado
            // 
            this.txtTrabajoRealizado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabajoRealizado.Location = new System.Drawing.Point(151, 170);
            this.txtTrabajoRealizado.Multiline = true;
            this.txtTrabajoRealizado.Name = "txtTrabajoRealizado";
            this.txtTrabajoRealizado.Size = new System.Drawing.Size(200, 59);
            this.txtTrabajoRealizado.TabIndex = 11;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(17, 35);
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
            this.lblTecnicoAsignado.Location = new System.Drawing.Point(17, 93);
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
            this.lblNoSerie.Location = new System.Drawing.Point(17, 64);
            this.lblNoSerie.Name = "lblNoSerie";
            this.lblNoSerie.Size = new System.Drawing.Size(66, 16);
            this.lblNoSerie.TabIndex = 6;
            this.lblNoSerie.Text = "No Serie:";
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
            this.btnImprimir.Location = new System.Drawing.Point(571, 535);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(156, 33);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEntregas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEntregas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(247)))), ((int)(((byte)(235)))));
            this.dgvEntregas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntregas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvEntregas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntregas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntregas.ColumnHeadersHeight = 25;
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntregas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntregas.EnableHeadersVisualStyles = false;
            this.dgvEntregas.GridColor = System.Drawing.Color.Turquoise;
            this.dgvEntregas.Location = new System.Drawing.Point(6, 30);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(247)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntregas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEntregas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(247)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEntregas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEntregas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntregas.Size = new System.Drawing.Size(468, 429);
            this.dgvEntregas.TabIndex = 1;
            // 
            // FrmEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(898, 585);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gpbBusqueda);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gpbTablaCliente);
            this.Controls.Add(this.gpbDatosEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEntrega";
            this.Text = "Entrega";
            this.gpbBusqueda.ResumeLayout(false);
            this.gpbBusqueda.PerformLayout();
            this.gpbTablaCliente.ResumeLayout(false);
            this.gpbDatosEntrega.ResumeLayout(false);
            this.gpbDatosEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gpbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFiltrado;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cmbFiltrado;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gpbTablaCliente;
        private System.Windows.Forms.GroupBox gpbDatosEntrega;
        private System.Windows.Forms.DateTimePicker dtFechaEntrega;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.TextBox txtNoCliente;
        private System.Windows.Forms.TextBox txtNoSerie;
        private System.Windows.Forms.TextBox txtTecnicoAsignado;
        private System.Windows.Forms.Label lblRepuesto;
        private System.Windows.Forms.TextBox txtRepuesto;
        private System.Windows.Forms.Label lblTrabajoRealizado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtTrabajoRealizado;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTecnicoAsignado;
        private System.Windows.Forms.Label lblNoSerie;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView dgvEntregas;
    }
}