namespace Presentacion
{
    partial class FrmTicketReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTicketReport));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Generar_Reportes_DataSet = new Presentacion.Generar_Reportes_DataSet();
            this.SP_DATOS_TICKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DATOS_TICKETTableAdapter = new Presentacion.Generar_Reportes_DataSetTableAdapters.SP_DATOS_TICKETTableAdapter();
            this.reportTicket = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Generar_Reportes_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_TICKETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Generar_Reportes_DataSet
            // 
            this.Generar_Reportes_DataSet.DataSetName = "Generar_Reportes_DataSet";
            this.Generar_Reportes_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_DATOS_TICKETBindingSource
            // 
            this.SP_DATOS_TICKETBindingSource.DataMember = "SP_DATOS_TICKET";
            this.SP_DATOS_TICKETBindingSource.DataSource = this.Generar_Reportes_DataSet;
            // 
            // SP_DATOS_TICKETTableAdapter
            // 
            this.SP_DATOS_TICKETTableAdapter.ClearBeforeFill = true;
            // 
            // reportTicket
            // 
            resources.ApplyResources(this.reportTicket, "reportTicket");
            reportDataSource3.Name = "Ticket_DataSet";
            reportDataSource3.Value = this.SP_DATOS_TICKETBindingSource;
            this.reportTicket.LocalReport.DataSources.Add(reportDataSource3);
            this.reportTicket.LocalReport.ReportEmbeddedResource = "Presentacion.ReportTicket.rdlc";
            this.reportTicket.Name = "reportTicket";
            // 
            // FrmTicketReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTicketReport";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.FrmTicketReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Generar_Reportes_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_TICKETBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Microsoft.Reporting.WinForms.ReportViewer reportTicket;
        private System.Windows.Forms.BindingSource SP_DATOS_TICKETBindingSource;
        private Generar_Reportes_DataSet Generar_Reportes_DataSet;
        private Generar_Reportes_DataSetTableAdapters.SP_DATOS_TICKETTableAdapter SP_DATOS_TICKETTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportTicket;
    }
}