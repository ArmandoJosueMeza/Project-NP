using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class Frm_Info_Proceso : Form
    {
        CN_Info_Proceso objetoCN = new CN_Info_Proceso();

        public void MostrarProceso()
        {
            CN_Info_Proceso objetoCN = new CN_Info_Proceso();
            dgvProcesos.DataSource = objetoCN.MostrarProceso();
        }
        public Frm_Info_Proceso()
        {
            InitializeComponent();
        }

        private void Frm_Info_Proceso_Load(object sender, EventArgs e)
        {
            MostrarProceso();
        }
    }
}
