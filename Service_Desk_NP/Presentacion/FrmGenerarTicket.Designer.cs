namespace Presentacion
{
    partial class FrmGenerarTicket
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarTicket));
            this.Generar_Ticket = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD_SERVICE_DESKDataSet = new Presentacion.BD_SERVICE_DESKDataSet();
            this.SP_DATOS_TICKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DATOS_TICKETTableAdapter = new Presentacion.BD_SERVICE_DESKDataSetTableAdapters.SP_DATOS_TICKETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_SERVICE_DESKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_TICKETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Generar_Ticket
            // 
            this.Generar_Ticket.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Generar_Ticket_DataSet";
            reportDataSource1.Value = this.SP_DATOS_TICKETBindingSource;
            this.Generar_Ticket.LocalReport.DataSources.Add(reportDataSource1);
            this.Generar_Ticket.LocalReport.ReportEmbeddedResource = "Presentacion.Ticket.rdlc";
            this.Generar_Ticket.Location = new System.Drawing.Point(0, 0);
            this.Generar_Ticket.Name = "Generar_Ticket";
            this.Generar_Ticket.ServerReport.BearerToken = null;
            this.Generar_Ticket.Size = new System.Drawing.Size(667, 450);
            this.Generar_Ticket.TabIndex = 0;
            // 
            // BD_SERVICE_DESKDataSet
            // 
            this.BD_SERVICE_DESKDataSet.DataSetName = "BD_SERVICE_DESKDataSet";
            this.BD_SERVICE_DESKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_DATOS_TICKETBindingSource
            // 
            this.SP_DATOS_TICKETBindingSource.DataMember = "SP_DATOS_TICKET";
            this.SP_DATOS_TICKETBindingSource.DataSource = this.BD_SERVICE_DESKDataSet;
            // 
            // SP_DATOS_TICKETTableAdapter
            // 
            this.SP_DATOS_TICKETTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGenerarTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.Generar_Ticket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGenerarTicket";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Ticket";
            this.Load += new System.EventHandler(this.FrmGenerarTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_SERVICE_DESKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_TICKETBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Generar_Ticket;
        private System.Windows.Forms.BindingSource SP_DATOS_TICKETBindingSource;
        private BD_SERVICE_DESKDataSet BD_SERVICE_DESKDataSet;
        private BD_SERVICE_DESKDataSetTableAdapters.SP_DATOS_TICKETTableAdapter SP_DATOS_TICKETTableAdapter;
    }
}