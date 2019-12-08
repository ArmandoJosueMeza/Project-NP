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
using Microsoft.Reporting.WinForms;
using Presentacion;
namespace Service_Desk_NP
{
    public partial class FrmEntrega : Form
    {
        CN_Entregas objetoCN = new CN_Entregas();
        private string NoEntrega = null;
        private bool Editar = false;
        string[] array_estados = { "PENDIENTE", "EN PROCESO", "FINALIZADO" };
        private string EstadoEntrega = null;
        private string FechaEntrega = null;
        public FrmEntrega()
        {
            InitializeComponent();
        }

        public void cargar_estados()
        {
            for (int i = 0; i < array_estados.Length; i++)
            {
                cmbEstado.Items.Add(array_estados[i].ToString());
            }
        }

        public void MostrarEntregas()
        {
            CN_Entregas objetoCN = new CN_Entregas();
            dgvEntregas.DataSource = objetoCN.MostrarEntregas("TODOS", "");
        }

        private void FrmEntrega_Load(object sender, EventArgs e)
        {
            MostrarEntregas();
            cargar_estados();
            cmbFiltrado.Items.Add("TODOS");
            cmbFiltrado.Items.Add("No. Ticket");
            cmbFiltrado.Items.Add("No. Cliente");
            cmbFiltrado.Items.Add("Estado");
            cmbFiltrado.Items.Add("Equipo");
        }

        public void LimpiarTextBox()
        {
            txtTicket.Clear();
            txtNoCliente.Clear();
            txtNoSerie.Clear();
            txtTecnicoAsignado.Clear();
            txtTrabajoRealizado.Clear();
            txtRepuesto.Clear();
            txtGarantia.Clear();
            txtBusqueda.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarEntregas(txtTicket.Text, txtNoCliente.Text, txtNoSerie.Text, txtTecnicoAsignado.Text, cmbEstado.SelectedIndex + 1, dtFechaEntrega.Value.Date.ToString("MM/dd/yyyy"), txtTrabajoRealizado.Text, txtRepuesto.Text, txtGarantia.Text);
                    MessageBox.Show("Guardado con exito");
                    MostrarEntregas();
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
                    objetoCN.EditarEntregas(txtTicket.Text, txtNoCliente.Text, txtNoSerie.Text, txtTecnicoAsignado.Text, cmbEstado.SelectedIndex + 1, dtFechaEntrega.Value.Date.ToString("MM/dd/yyyy"), txtTrabajoRealizado.Text, txtRepuesto.Text, txtGarantia.Text, NoEntrega);
                    MessageBox.Show("Edito con exito");
                    MostrarEntregas();
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
            if (dgvEntregas.SelectedRows.Count > 0)
            {
                Editar = true;
                txtTicket.Text = dgvEntregas.CurrentRow.Cells["No. Ticket"].Value.ToString();
                txtNoCliente.Text = dgvEntregas.CurrentRow.Cells["No. Cliente"].Value.ToString();
                txtNoSerie.Text = dgvEntregas.CurrentRow.Cells["No. Serie"].Value.ToString();
                txtTecnicoAsignado.Text = dgvEntregas.CurrentRow.Cells["No. Tecnico Asignado"].Value.ToString();

                EstadoEntrega = dgvEntregas.CurrentRow.Cells["Estado"].Value.ToString();
                cmbEstado.Text = EstadoEntrega;

                FechaEntrega = dgvEntregas.CurrentRow.Cells["Fecha de ingreso"].Value.ToString();
                dtFechaEntrega.Text = FechaEntrega;
                FechaEntrega = dtFechaEntrega.Value.Date.ToShortDateString();

                txtTrabajoRealizado.Text = dgvEntregas.CurrentRow.Cells["Trabajo realizado"].Value.ToString();
                txtRepuesto.Text = dgvEntregas.CurrentRow.Cells["Repuestos utilizados"].Value.ToString();
                txtGarantia.Text = dgvEntregas.CurrentRow.Cells["Garantia"].Value.ToString();
                NoEntrega = dgvEntregas.CurrentRow.Cells["No. Entrega"].Value.ToString(); 
            }
            else
                MessageBox.Show("Por favor selecione una fila");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEntregas.SelectedRows.Count > 0)
            {
                NoEntrega = dgvEntregas.CurrentRow.Cells["No. Entrega"].Value.ToString(); ;
                objetoCN.EliminarEntregas(NoEntrega);
                MessageBox.Show("Elimino con exito");
                MostrarEntregas();
            }
            else
            {
                MessageBox.Show("Por favor selecione una fila");
            }
        }

        private void dtFechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            FechaEntrega = dtFechaEntrega.Value.Date.ToString("MM/dd/yyyy");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CN_Entregas objetoCN = new CN_Entregas();
            dgvEntregas.DataSource = objetoCN.MostrarEntregas(cmbFiltrado.Text, txtBusqueda.Text);
            LimpiarTextBox();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvEntregas.SelectedRows.Count > 0)
            {
                NoEntrega = dgvEntregas.CurrentRow.Cells["No. Entrega"].Value.ToString();

                FrmGenerarEntrega generarEntrega = new FrmGenerarEntrega(NoEntrega);
                MessageBox.Show("Generando Entrega");
                generarEntrega.ShowDialog();
                MostrarEntregas();
                LimpiarTextBox();

            }
            else
            {
                MessageBox.Show("Por favor selecione una fila");
            }
        }
    }
}
