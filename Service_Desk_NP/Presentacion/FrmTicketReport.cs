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
    public partial class FrmTicketReport : Form
    {
        private string NoTicket;
        public FrmTicketReport(string NoTicket)
        {
            InitializeComponent();
            this.NoTicket = NoTicket;
        }

        private void FrmTicketReport_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Generar_Reportes_DataSet.SP_DATOS_TICKET' Puede moverla o quitarla según sea necesario.
            this.SP_DATOS_TICKETTableAdapter.Fill(this.Generar_Reportes_DataSet.SP_DATOS_TICKET,NoTicket);
            reportTicket.LocalReport.DisplayName = NoTicket;

          
            this.reportTicket.RefreshReport();
        }
    }
}
