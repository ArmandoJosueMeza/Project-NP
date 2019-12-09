namespace Presentacion
{
    partial class FrmEntregaReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntregaReport));
            this.reportEntrega = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Generar_Reportes_DataSet = new Presentacion.Generar_Reportes_DataSet();
            this.SP_DATOS_ENTREGABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DATOS_ENTREGATableAdapter = new Presentacion.Generar_Reportes_DataSetTableAdapters.SP_DATOS_ENTREGATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Generar_Reportes_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_ENTREGABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportEntrega
            // 
            this.reportEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Entrega_DataSet";
            reportDataSource1.Value = this.SP_DATOS_ENTREGABindingSource;
            this.reportEntrega.LocalReport.DataSources.Add(reportDataSource1);
            this.reportEntrega.LocalReport.ReportEmbeddedResource = "Presentacion.ReportEntrega.rdlc";
            this.reportEntrega.Location = new System.Drawing.Point(0, 0);
            this.reportEntrega.Name = "reportEntrega";
            this.reportEntrega.Size = new System.Drawing.Size(784, 631);
            this.reportEntrega.TabIndex = 0;
            // 
            // Generar_Reportes_DataSet
            // 
            this.Generar_Reportes_DataSet.DataSetName = "Generar_Reportes_DataSet";
            this.Generar_Reportes_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_DATOS_ENTREGABindingSource
            // 
            this.SP_DATOS_ENTREGABindingSource.DataMember = "SP_DATOS_ENTREGA";
            this.SP_DATOS_ENTREGABindingSource.DataSource = this.Generar_Reportes_DataSet;
            // 
            // SP_DATOS_ENTREGATableAdapter
            // 
            this.SP_DATOS_ENTREGATableAdapter.ClearBeforeFill = true;
            // 
            // FrmEntregaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 631);
            this.Controls.Add(this.reportEntrega);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEntregaReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrega";
            this.Load += new System.EventHandler(this.FrmEntregaReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Generar_Reportes_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_ENTREGABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportEntrega;
        private System.Windows.Forms.BindingSource SP_DATOS_ENTREGABindingSource;
        private Generar_Reportes_DataSet Generar_Reportes_DataSet;
        private Generar_Reportes_DataSetTableAdapters.SP_DATOS_ENTREGATableAdapter SP_DATOS_ENTREGATableAdapter;
    }
}