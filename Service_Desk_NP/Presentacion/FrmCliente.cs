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

namespace Service_Desk_NP
{
    public partial class FrmCliente : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        public FrmCliente()
        {
            InitializeComponent();
        }

        public void MostrarClientes()
        {
            CN_Clientes objetoCN = new CN_Clientes();
            dgvClientes.DataSource = objetoCN.MostrarClientes();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //MostarInicio(new FrmInicio());
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.InsertarCliente(txtNombre.Text, txtApellido.Text, txtEmpresa.Text, txtUbicacion.Text, txtTelefono.Text, txtCorreo.Text);
                MessageBox.Show("Guardado con exito");
                MostrarClientes();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se guardo la informacion por: " + ex);
            }
           
        }
    }
}
