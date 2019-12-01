using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Negocios;

namespace Service_Desk_NP
{
  
    public partial class FrmTicket : Form
    {
        CN_Tickets objetoCN = new CN_Tickets();
        private string NoTicket = null;
        private bool Editar = false;
        string[] array_estados = { "PENDIENTE", "EN PROCESO", "FINALIZADO" };
        private string EstadoTicket = null;
        private string FechaIngreso = null;
        public FrmTicket()
        {
            InitializeComponent();
        }

        public void MostrarTickets()
        {
            CN_Tickets objetoCN = new CN_Tickets();
            dgvTickets.DataSource = objetoCN.MostrarTickets("TODOS", "");  
        }


       public void cargar_estados()
        {
            for (int i=0; i<array_estados.Length; i++)
            {
                cmbEstado.Items.Add(array_estados[i].ToString());
            }
        }

        private void FrmTicket_Load(object sender, EventArgs e)
        {
            MostrarTickets();
            cargar_estados();
            cmbFiltrado.Items.Add("TODOS");
            cmbFiltrado.Items.Add("No. Ticket");
            cmbFiltrado.Items.Add("Estado");
            cmbFiltrado.Items.Add("Fecha de Ingreso");
        }

        public void LimpiarTextBox()
        {
            txtNoCliente.Clear();
            txtNoSerie.Clear();
            txtTecnicoAsignado.Clear();
            txtProblema.Clear();
            txtObservaciones.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    
                    objetoCN.InsertarTickets(txtNoCliente.Text, txtNoSerie.Text, txtTecnicoAsignado.Text, dateFechaIngreso.Value.Date.ToString("MM/dd/yyyy"), cmbEstado.SelectedIndex +1, txtProblema.Text, txtObservaciones.Text);
                    MessageBox.Show("Guardado con exito");
                    MostrarTickets();
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
                    objetoCN.EditarTickets(txtNoCliente.Text, txtNoSerie.Text, txtTecnicoAsignado.Text, dateFechaIngreso.Value.Date.ToString("MM/dd/yyyy"), cmbEstado.SelectedIndex + 1, txtProblema.Text, txtObservaciones.Text, NoTicket);
                    MessageBox.Show("Edito con exito");
                    MostrarTickets();
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
            if (dgvTickets.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNoCliente.Text = dgvTickets.CurrentRow.Cells["No. Cliente"].Value.ToString();
                txtNoSerie.Text = dgvTickets.CurrentRow.Cells["No. Serie"].Value.ToString();
                txtTecnicoAsignado.Text = dgvTickets.CurrentRow.Cells["No. Tecnico Asignado"].Value.ToString();

                EstadoTicket = dgvTickets.CurrentRow.Cells["Estado"].Value.ToString();
                cmbEstado.Text = EstadoTicket;
                lblEstado.Text = cmbEstado.ToString();

                FechaIngreso = dgvTickets.CurrentRow.Cells["Fecha de ingreso"].Value.ToString();
                dateFechaIngreso.Text = FechaIngreso;
                FechaIngreso = dateFechaIngreso.Value.Date.ToShortDateString();
                lblFecha.Text = FechaIngreso.ToString();



                txtProblema.Text = dgvTickets.CurrentRow.Cells["Problema reportado"].Value.ToString();
                txtObservaciones.Text = dgvTickets.CurrentRow.Cells["Observaciones"].Value.ToString();
                NoTicket = dgvTickets.CurrentRow.Cells["No. Ticket"].Value.ToString(); ;
            }
            else
                MessageBox.Show("Por favor selecione una fila");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                NoTicket = dgvTickets.CurrentRow.Cells["No. Ticket"].Value.ToString(); ;
                objetoCN.EliminarTickets(NoTicket);
                MessageBox.Show("Elimino con exito");
                MostrarTickets();
            }
            else
            {
                MessageBox.Show("Por favor selecione una fila");
            }
                
        }

        private void dateFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            FechaIngreso = dateFechaIngreso.Value.Date.ToString("MM/dd/yyyy");
            lblFecha.Text = FechaIngreso.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CN_Tickets objetoCN = new CN_Tickets();
            dgvTickets.DataSource = objetoCN.MostrarTickets(cmbFiltrado.Text, txtBusqueda.Text);
        }
    }
}
