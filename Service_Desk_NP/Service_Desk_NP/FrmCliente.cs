using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Desk_NP
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //MostarInicio(new FrmInicio());
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /* private void MostarInicio(object FormInicio)
         {
             Form fi = FormInicio as Form;
             fi.TopLevel = false;
             fi.Dock = DockStyle.Fill;
             fi.Show();
         }*/
    }
}
