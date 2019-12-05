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
    public partial class FrmGenerarTicket : Form
    {
        private string NoTicket;
        public FrmGenerarTicket(string NoTicket)
        {
            InitializeComponent();
            this.NoTicket = NoTicket;
        }

        private void FrmGenerarTicket_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_SERVICE_DESK_GENERAR_TICKET.SP_DATOS_TICKET' Puede moverla o quitarla según sea necesario.
            this.SP_DATOS_TICKETTableAdapter.Fill(this.BD_SERVICE_DESK_GENERAR_TICKET.SP_DATOS_TICKET, NoTicket);

            this.reportGenerarTicket.RefreshReport();
        }
    }
}
