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
    public partial class Frm_Info_Pendiente : Form
    {
        CN_Info_Pendiente objetoCN = new CN_Info_Pendiente();

        public void MostrarPendientes()
        {
            CN_Info_Pendiente objetoCN = new CN_Info_Pendiente();
            dgvPendientes.DataSource = objetoCN.MostrarPendiente();
        }
        public Frm_Info_Pendiente()
        {
            InitializeComponent();
        }

        private void Frm_Info_Pendiente_Load(object sender, EventArgs e)
        {
            MostrarPendientes();
        }
    }
}
