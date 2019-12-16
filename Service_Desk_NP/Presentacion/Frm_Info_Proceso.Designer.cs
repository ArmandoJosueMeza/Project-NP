namespace Presentacion
{
    partial class Frm_Info_Proceso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Info_Proceso));
            this.gpbTablaProceso = new System.Windows.Forms.GroupBox();
            this.dgvProcesos = new System.Windows.Forms.DataGridView();
            this.gpbTablaProceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbTablaProceso
            // 
            this.gpbTablaProceso.Controls.Add(this.dgvProcesos);
            this.gpbTablaProceso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTablaProceso.ForeColor = System.Drawing.Color.White;
            this.gpbTablaProceso.Location = new System.Drawing.Point(12, 12);
            this.gpbTablaProceso.Name = "gpbTablaProceso";
            this.gpbTablaProceso.Size = new System.Drawing.Size(876, 600);
            this.gpbTablaProceso.TabIndex = 118;
            this.gpbTablaProceso.TabStop = false;
            this.gpbTablaProceso.Text = "SERVICIOS EN PROCESO";
            // 
            // dgvProcesos
            // 
            this.dgvProcesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProcesos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProcesos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(247)))), ((int)(((byte)(235)))));
            this.dgvProcesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProcesos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProcesos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcesos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcesos.ColumnHeadersHeight = 25;
            this.dgvProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcesos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProcesos.EnableHeadersVisualStyles = false;
            this.dgvProcesos.GridColor = System.Drawing.Color.Turquoise;
            this.dgvProcesos.Location = new System.Drawing.Point(6, 30);
            this.dgvProcesos.Name = "dgvProcesos";
            this.dgvProcesos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(247)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcesos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProcesos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(247)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProcesos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProcesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcesos.Size = new System.Drawing.Size(864, 564);
            this.dgvProcesos.TabIndex = 1;
            // 
            // Frm_Info_Proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(900, 624);
            this.Controls.Add(this.gpbTablaProceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Info_Proceso";
            this.Text = "Frm_Info_Proceso";
            this.Load += new System.EventHandler(this.Frm_Info_Proceso_Load);
            this.gpbTablaProceso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTablaProceso;
        private System.Windows.Forms.DataGridView dgvProcesos;
    }
}