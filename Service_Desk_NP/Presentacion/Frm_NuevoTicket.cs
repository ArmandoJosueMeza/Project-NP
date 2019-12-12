using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Negocios;

namespace Presentacion
{
    public partial class Frm_NuevoTicket : Form
    {
        CN_NuevoTicket objetoCN = new CN_NuevoTicket();
        ReportDataSource rs = new ReportDataSource();
        string[] array_estados = { "PENDIENTE", "EN PROCESO", "FINALIZADO" };
        private bool editar = false;
        private string no_ticket = null;
        private string estado = null;
        private string fecha = null;

        public void cargar_estados()
        {
            for (int i = 0; i < array_estados.Length; i++)
            {
                cmbEstado.Items.Add(array_estados[i].ToString());
            }
        }

        public void MostrarNuevoTickets()
        {
            CN_NuevoTicket objetoCN = new CN_NuevoTicket();
            dgvTickets.DataSource = objetoCN.MostrarNuevoTickets("TODOS", "");
        }

        public void LimpiarTextBox()
        {
            txtCliente.Clear();
            txtSerie.Clear();
            txtTecnico.Clear();
            txtProblema.Clear();
            txtObservaciones.Clear();
            txtBusqueda.Clear();
        }
        public Frm_NuevoTicket()
        {
            InitializeComponent();
        }

        private void Frm_NuevoTicket_Load(object sender, EventArgs e)
        {
            MostrarNuevoTickets();
            cargar_estados();
            cmbFiltrado.Items.Add("TODOS");
            cmbFiltrado.Items.Add("No. Ticket");
            cmbFiltrado.Items.Add("No. Cliente");
            cmbFiltrado.Items.Add("Estado");
            cmbFiltrado.Items.Add("Equipo");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objetoCN.InsertarNuevoTickets(txtCliente.Text, txtSerie.Text, txtTecnico.Text, dtFecha.Value.Date.ToString("dd/MM/yyyy"), cmbEstado.SelectedIndex + 1,  txtProblema.Text, txtObservaciones.Text);
                    MessageBox.Show("Guardado con exito");
                    MostrarNuevoTickets();
                    LimpiarTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se guardo la informacion por: " + ex);
                }
            }

            if (editar == true)
            {
                try
                {
                    objetoCN.EditarNuevoTickets(txtCliente.Text, txtSerie.Text, txtTecnico.Text, dtFecha.Value.Date.ToString("dd/MM/yyyy"), cmbEstado.SelectedIndex + 1, txtProblema.Text, txtObservaciones.Text, no_ticket);
                    MessageBox.Show("Edito con exito");
                    MostrarNuevoTickets();
                    LimpiarTextBox();
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
                editar = true;
                txtCliente.Text = dgvTickets.CurrentRow.Cells["No. Cliente"].Value.ToString();
                txtSerie.Text = dgvTickets.CurrentRow.Cells["No. Serie"].Value.ToString();
                txtTecnico.Text = dgvTickets.CurrentRow.Cells["No. Tecnico Asignado"].Value.ToString();

                estado = dgvTickets.CurrentRow.Cells["Estado"].Value.ToString();
                cmbEstado.Text = estado;

                fecha = dgvTickets.CurrentRow.Cells["Fecha de ingreso"].Value.ToString();
                dtFecha.Text = fecha;
                fecha = dtFecha.Value.Date.ToShortDateString();

                txtProblema.Text = dgvTickets.CurrentRow.Cells["Problema reportado"].Value.ToString();
                txtObservaciones.Text = dgvTickets.CurrentRow.Cells["Observaciones"].Value.ToString();
                no_ticket = dgvTickets.CurrentRow.Cells["No. Ticket"].Value.ToString();
            }
            else
                MessageBox.Show("Por favor selecione una fila");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                no_ticket = dgvTickets.CurrentRow.Cells["No. Ticket"].Value.ToString(); ;
                objetoCN.EliminarTickets(no_ticket);
                MessageBox.Show("Elimino con exito");
                MostrarNuevoTickets();
            }
            else
            {
                MessageBox.Show("Por favor selecione una fila");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                no_ticket = dgvTickets.CurrentRow.Cells["No. Ticket"].Value.ToString();

                FrmTicketReport generarEntrega = new FrmTicketReport(no_ticket);
                MessageBox.Show("Generando Comprobante de entrega");
                generarEntrega.ShowDialog();
                MostrarNuevoTickets();
                LimpiarTextBox();

            }
            else
            {
                MessageBox.Show("Por favor selecione una fila");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CN_NuevoTicket objetoCN = new CN_NuevoTicket();
            dgvTickets.DataSource = objetoCN.MostrarNuevoTickets(cmbFiltrado.Text, txtBusqueda.Text);
            LimpiarTextBox();
        }
    }
}
