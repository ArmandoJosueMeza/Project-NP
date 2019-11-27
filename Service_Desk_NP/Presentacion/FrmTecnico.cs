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
    public partial class FrmTecnico : Form
    {
        CN_Tecnicos objetoCN = new CN_Tecnicos();
        private string NoTecnico = null;
        private bool Editar = false;
        public FrmTecnico()
        {
            InitializeComponent();
        }

        public void MostrarTecnicos()
        {
            CN_Tecnicos objetoCN = new CN_Tecnicos();
            dgvTecnicos.DataSource = objetoCN.MostrarTecnicos();
        }

        private void FrmTecnico_Load(object sender, EventArgs e)
        {
            MostrarTecnicos();
        }

        public void LimpiarTextBox()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarTecnicos(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text);
                    MessageBox.Show("Guardado con exito");
                    MostrarTecnicos();
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
                    objetoCN.EditarTecnicos(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, NoTecnico);
                    MessageBox.Show("Edito con exito");
                    MostrarTecnicos();
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
            if (dgvTecnicos.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dgvTecnicos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvTecnicos.CurrentRow.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = dgvTecnicos.CurrentRow.Cells["Numero de teléfono"].Value.ToString();
                txtCorreo.Text = dgvTecnicos.CurrentRow.Cells["Correo electrónico"].Value.ToString();
                NoTecnico = dgvTecnicos.CurrentRow.Cells["No. Tecnico"].Value.ToString(); ;
            }
            else
                MessageBox.Show("Por favor selecione una fila");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTecnicos.SelectedRows.Count > 0)
            {
                NoTecnico = dgvTecnicos.CurrentRow.Cells["No. Tecnico"].Value.ToString(); ;
                objetoCN.EliminarTecnicos(NoTecnico);
                MessageBox.Show("Elimino con exito");
                MostrarTecnicos();
            }
            else
                MessageBox.Show("Por favor selecione una fila");
        }
    }
}
