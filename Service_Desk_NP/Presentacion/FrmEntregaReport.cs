using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmEntregaReport : Form
    {
        private string NoEntrega;
        public FrmEntregaReport(string NoEntrega)
        {
            InitializeComponent();
            this.NoEntrega = NoEntrega;
        }

        private void FrmEntregaReport_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Generar_Reportes_DataSet.SP_DATOS_ENTREGA' Puede moverla o quitarla según sea necesario.
            this.SP_DATOS_ENTREGATableAdapter.Fill(this.Generar_Reportes_DataSet.SP_DATOS_ENTREGA, NoEntrega);
            reportEntrega.LocalReport.DisplayName = NoEntrega;

            this.reportEntrega.RefreshReport();
        }
    }
}
