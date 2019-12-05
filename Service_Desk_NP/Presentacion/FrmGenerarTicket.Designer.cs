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
            this.reportGenerarTicket = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD_SERVICE_DESK_GENERAR_TICKET = new Presentacion.BD_SERVICE_DESK_GENERAR_TICKET();
            this.SP_DATOS_TICKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DATOS_TICKETTableAdapter = new Presentacion.BD_SERVICE_DESK_GENERAR_TICKETTableAdapters.SP_DATOS_TICKETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_SERVICE_DESK_GENERAR_TICKET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_TICKETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportGenerarTicket
            // 
            this.reportGenerarTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GENERAR_TICKET";
            reportDataSource1.Value = this.SP_DATOS_TICKETBindingSource;
            this.reportGenerarTicket.LocalReport.DataSources.Add(reportDataSource1);
            this.reportGenerarTicket.LocalReport.ReportEmbeddedResource = "Presentacion.GenerarTicket.rdlc";
            this.reportGenerarTicket.Location = new System.Drawing.Point(0, 0);
            this.reportGenerarTicket.Name = "reportGenerarTicket";
            this.reportGenerarTicket.ServerReport.BearerToken = null;
            this.reportGenerarTicket.Size = new System.Drawing.Size(800, 450);
            this.reportGenerarTicket.TabIndex = 0;
            // 
            // BD_SERVICE_DESK_GENERAR_TICKET
            // 
            this.BD_SERVICE_DESK_GENERAR_TICKET.DataSetName = "BD_SERVICE_DESK_GENERAR_TICKET";
            this.BD_SERVICE_DESK_GENERAR_TICKET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_DATOS_TICKETBindingSource
            // 
            this.SP_DATOS_TICKETBindingSource.DataMember = "SP_DATOS_TICKET";
            this.SP_DATOS_TICKETBindingSource.DataSource = this.BD_SERVICE_DESK_GENERAR_TICKET;
            // 
            // SP_DATOS_TICKETTableAdapter
            // 
            this.SP_DATOS_TICKETTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGenerarTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportGenerarTicket);
            this.Name = "FrmGenerarTicket";
            this.Text = "FrmGenerarTicket";
            this.Load += new System.EventHandler(this.FrmGenerarTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_SERVICE_DESK_GENERAR_TICKET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_TICKETBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportGenerarTicket;
        private System.Windows.Forms.BindingSource SP_DATOS_TICKETBindingSource;
        private BD_SERVICE_DESK_GENERAR_TICKET BD_SERVICE_DESK_GENERAR_TICKET;
        private BD_SERVICE_DESK_GENERAR_TICKETTableAdapters.SP_DATOS_TICKETTableAdapter SP_DATOS_TICKETTableAdapter;
    }
}