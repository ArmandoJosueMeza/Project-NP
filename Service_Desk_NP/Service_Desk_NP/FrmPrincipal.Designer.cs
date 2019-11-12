namespace Service_Desk_NP
{
    partial class FrmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnExpandir = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.btnContraer = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.btnTecnico = new System.Windows.Forms.Button();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.toolMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContraer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.White;
            this.barraTitulo.Controls.Add(this.btnExpandir);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnSlide);
            this.barraTitulo.Controls.Add(this.btnContraer);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(294, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(912, 40);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnExpandir
            // 
            this.btnExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpandir.Image = ((System.Drawing.Image)(resources.GetObject("btnExpandir.Image")));
            this.btnExpandir.Location = new System.Drawing.Point(828, 10);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(20, 20);
            this.btnExpandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExpandir.TabIndex = 2;
            this.btnExpandir.TabStop = false;
            this.toolMensaje.SetToolTip(this.btnExpandir, "Maximizar");
            this.btnExpandir.Click += new System.EventHandler(this.BtnExpandir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(880, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.toolMensaje.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(776, 10);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.toolMensaje.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(3, 3);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(30, 30);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.toolMensaje.SetToolTip(this.btnSlide, "Expandir menu");
            this.btnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // btnContraer
            // 
            this.btnContraer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContraer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContraer.Image = ((System.Drawing.Image)(resources.GetObject("btnContraer.Image")));
            this.btnContraer.Location = new System.Drawing.Point(828, 10);
            this.btnContraer.Name = "btnContraer";
            this.btnContraer.Size = new System.Drawing.Size(20, 20);
            this.btnContraer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnContraer.TabIndex = 3;
            this.btnContraer.TabStop = false;
            this.toolMensaje.SetToolTip(this.btnContraer, "Restaurar a tamaño normal");
            this.btnContraer.Visible = false;
            this.btnContraer.Click += new System.EventHandler(this.BtnContraer_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(294, 40);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(912, 610);
            this.panelContenedor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolMensaje.SetToolTip(this.pictureBox1, "Pagina principal");
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.White;
            this.menuVertical.Controls.Add(this.btnArticulo);
            this.menuVertical.Controls.Add(this.btnTecnico);
            this.menuVertical.Controls.Add(this.btnEntrega);
            this.menuVertical.Controls.Add(this.btnTicket);
            this.menuVertical.Controls.Add(this.btnCliente);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(294, 650);
            this.menuVertical.TabIndex = 0;
            // 
            // btnArticulo
            // 
            this.btnArticulo.FlatAppearance.BorderSize = 0;
            this.btnArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnArticulo.Image")));
            this.btnArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulo.Location = new System.Drawing.Point(3, 192);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(291, 79);
            this.btnArticulo.TabIndex = 4;
            this.btnArticulo.Text = "Articulo";
            this.toolMensaje.SetToolTip(this.btnArticulo, "Articulo");
            this.btnArticulo.UseVisualStyleBackColor = true;
            // 
            // btnTecnico
            // 
            this.btnTecnico.FlatAppearance.BorderSize = 0;
            this.btnTecnico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTecnico.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTecnico.Image = ((System.Drawing.Image)(resources.GetObject("btnTecnico.Image")));
            this.btnTecnico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTecnico.Location = new System.Drawing.Point(3, 447);
            this.btnTecnico.Name = "btnTecnico";
            this.btnTecnico.Size = new System.Drawing.Size(291, 79);
            this.btnTecnico.TabIndex = 3;
            this.btnTecnico.Text = "Tecnico";
            this.toolMensaje.SetToolTip(this.btnTecnico, "Tecnico");
            this.btnTecnico.UseVisualStyleBackColor = true;
            // 
            // btnEntrega
            // 
            this.btnEntrega.FlatAppearance.BorderSize = 0;
            this.btnEntrega.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrega.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEntrega.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrega.Image")));
            this.btnEntrega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrega.Location = new System.Drawing.Point(3, 362);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(367, 79);
            this.btnEntrega.TabIndex = 2;
            this.btnEntrega.Text = "Entrega equipo";
            this.toolMensaje.SetToolTip(this.btnEntrega, "Entrega de Equipo");
            this.btnEntrega.UseVisualStyleBackColor = true;
            // 
            // btnTicket
            // 
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnTicket.Image")));
            this.btnTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.Location = new System.Drawing.Point(3, 277);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(291, 79);
            this.btnTicket.TabIndex = 1;
            this.btnTicket.Text = "Ticket";
            this.toolMensaje.SetToolTip(this.btnTicket, "Ticket");
            this.btnTicket.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(3, 107);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(291, 79);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.toolMensaje.SetToolTip(this.btnCliente, "Cliente");
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExpandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContraer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnContraer;
        private System.Windows.Forms.PictureBox btnExpandir;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.ToolTip toolMensaje;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.Button btnTecnico;
        private System.Windows.Forms.Button btnArticulo;
    }
}

