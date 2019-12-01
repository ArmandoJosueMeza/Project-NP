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
        private string NoCliente=null;
        private bool Editar = false;
        public FrmCliente()
        {
            InitializeComponent();
        }

        public void MostrarClientes()
        {
            CN_Clientes objetoCN = new CN_Clientes();
            dgvClientes.DataSource = objetoCN.MostrarClientes("TODOS", ""); 
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            cmbFiltrado.Items.Add("TODOS");
            cmbFiltrado.Items.Add("Nombre");
            cmbFiltrado.Items.Add("Apellido");
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //MostarInicio(new FrmInicio());
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false) 
            { 
                try
                {
                    objetoCN.InsertarCliente(txtNombre.Text, txtApellido.Text, txtEmpresa.Text, txtUbicacion.Text, txtTelefono.Text, txtCorreo.Text);
                    MessageBox.Show("Guardado con exito");
                    MostrarClientes();
                    LimpiarTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se guardo la informacion por: " + ex);
                }
            }
            if (Editar == true) 
            { 
                try
                {
                    objetoCN.EditarClientes(txtNombre.Text, txtApellido.Text, txtEmpresa.Text, txtUbicacion.Text, txtTelefono.Text, txtCorreo.Text, NoCliente);
                    MessageBox.Show("Edito con exito");
                    MostrarClientes();
                    LimpiarTextBox();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se edito la informacion por: " + ex);
                }

            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtEmpresa.Text = dgvClientes.CurrentRow.Cells["Empresa"].Value.ToString();
                txtUbicacion.Text = dgvClientes.CurrentRow.Cells["Ubicación"].Value.ToString();
                txtTelefono.Text = dgvClientes.CurrentRow.Cells["Numero de teléfono"].Value.ToString();
                txtCorreo.Text = dgvClientes.CurrentRow.Cells["Correo electrónico"].Value.ToString();
                NoCliente = dgvClientes.CurrentRow.Cells["No. Cliente"].Value.ToString(); ;
            }
            else
                MessageBox.Show("Por favor selecione una fila");
        }
        public void LimpiarTextBox()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmpresa.Clear();
            txtUbicacion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                NoCliente = dgvClientes.CurrentRow.Cells["No. Cliente"].Value.ToString(); ;
                objetoCN.EliminarClientes(NoCliente);
                MessageBox.Show("Elimino con exito");
                MostrarClientes();
            }
            else
                MessageBox.Show("Por favor selecione una fila");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CN_Clientes objetoCN = new CN_Clientes();
            dgvClientes.DataSource = objetoCN.MostrarClientes(cmbFiltrado.Text, txtBusqueda.Text);
        }
    }
}
