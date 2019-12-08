namespace Presentacion
{
    partial class FrmGenerarEntrega
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
            this.reportEntrega = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD_SERVICE_DESKDataSet = new Presentacion.BD_SERVICE_DESKDataSet();
            this.SP_DATOS_ENTREGABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DATOS_ENTREGATableAdapter = new Presentacion.BD_SERVICE_DESKDataSetTableAdapters.SP_DATOS_ENTREGATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_SERVICE_DESKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_ENTREGABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportEntrega
            // 
            this.reportEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Entrega";
            reportDataSource1.Value = this.SP_DATOS_ENTREGABindingSource;
            this.reportEntrega.LocalReport.DataSources.Add(reportDataSource1);
            this.reportEntrega.LocalReport.ReportEmbeddedResource = "Presentacion.Entrega.rdlc";
            this.reportEntrega.Location = new System.Drawing.Point(0, 0);
            this.reportEntrega.Name = "reportEntrega";
            this.reportEntrega.ServerReport.BearerToken = null;
            this.reportEntrega.Size = new System.Drawing.Size(800, 450);
            this.reportEntrega.TabIndex = 0;
            // 
            // BD_SERVICE_DESKDataSet
            // 
            this.BD_SERVICE_DESKDataSet.DataSetName = "BD_SERVICE_DESKDataSet";
            this.BD_SERVICE_DESKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_DATOS_ENTREGABindingSource
            // 
            this.SP_DATOS_ENTREGABindingSource.DataMember = "SP_DATOS_ENTREGA";
            this.SP_DATOS_ENTREGABindingSource.DataSource = this.BD_SERVICE_DESKDataSet;
            // 
            // SP_DATOS_ENTREGATableAdapter
            // 
            this.SP_DATOS_ENTREGATableAdapter.ClearBeforeFill = true;
            // 
            // FrmGenerarEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportEntrega);
            this.Name = "FrmGenerarEntrega";
            this.Text = "FrmGenerarEntrega";
            this.Load += new System.EventHandler(this.FrmGenerarEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_SERVICE_DESKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_ENTREGABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportEntrega;
        private System.Windows.Forms.BindingSource SP_DATOS_ENTREGABindingSource;
        private BD_SERVICE_DESKDataSet BD_SERVICE_DESKDataSet;
        private BD_SERVICE_DESKDataSetTableAdapters.SP_DATOS_ENTREGATableAdapter SP_DATOS_ENTREGATableAdapter;
    }
}