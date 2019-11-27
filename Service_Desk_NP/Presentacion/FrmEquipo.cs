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
    public partial class FrmEquipo : Form
    {
        CN_Equipos objetoCN = new CN_Equipos();
        private string NoEquipo = null;
        private bool Editar = false;

        public void MostrarEquipos()
        {
            CN_Equipos objetoCN = new CN_Equipos();
            dgvEquipos.DataSource = objetoCN.MostrarEquipos();
        }
        public FrmEquipo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            MostrarEquipos();

        }
        public void LimpiarTextBox()
        {
            txtNoCliente.Clear();
            txtEquipo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtNoSerie.Clear();
            txtClaveAcceso.Clear();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarEquipos(txtNoCliente.Text, txtEquipo.Text, txtMarca.Text, txtModelo.Text, txtNoSerie.Text, txtClaveAcceso.Text);
                    MessageBox.Show("Guardado con exito");
                    MostrarEquipos();
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
                    objetoCN.EditarEquipos(txtNoCliente.Text, txtEquipo.Text, txtMarca.Text, txtModelo.Text, txtNoSerie.Text, txtClaveAcceso.Text);
                    MessageBox.Show("Edito con exito");
                    MostrarEquipos();
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
            if (dgvEquipos.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNoCliente.Text = dgvEquipos.CurrentRow.Cells["No. Cliente"].Value.ToString();
                txtEquipo.Text = dgvEquipos.CurrentRow.Cells["Descripción del equipo"].Value.ToString();
                txtMarca.Text = dgvEquipos.CurrentRow.Cells["Marca"].Value.ToString();
                txtModelo.Text = dgvEquipos.CurrentRow.Cells["Modelo"].Value.ToString();
                txtNoSerie.Text = dgvEquipos.CurrentRow.Cells["No. Serie"].Value.ToString();
                txtClaveAcceso.Text = dgvEquipos.CurrentRow.Cells["Clave de acceso"].Value.ToString();
                NoEquipo = dgvEquipos.CurrentRow.Cells["No. Serie"].Value.ToString(); ;
            }
            else
                MessageBox.Show("Por favor selecione una fila");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count > 0)
            {
                NoEquipo = dgvEquipos.CurrentRow.Cells["No. Serie"].Value.ToString(); ;
                objetoCN.EliminarEquipos(NoEquipo);
                MessageBox.Show("Elimino con exito");
                MostrarEquipos();
            }
            else
                MessageBox.Show("Por favor selecione una fila");

        }
    }
}
