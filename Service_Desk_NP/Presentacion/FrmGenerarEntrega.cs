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
    public partial class FrmGenerarEntrega : Form
    {
        private string NoEntrega;
        public FrmGenerarEntrega(string NoEntrega)
        {
            InitializeComponent();
            this.NoEntrega = NoEntrega;
        }

        private void FrmGenerarEntrega_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_SERVICE_DESKDataSet.SP_DATOS_ENTREGA' Puede moverla o quitarla según sea necesario.
            this.SP_DATOS_ENTREGATableAdapter.Fill(this.BD_SERVICE_DESKDataSet.SP_DATOS_ENTREGA, NoEntrega);

            this.reportEntrega.RefreshReport();
        }
    }
}
