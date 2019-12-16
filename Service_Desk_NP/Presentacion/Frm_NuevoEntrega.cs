using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Negocios;


namespace Presentacion
{
    public partial class Frm_NuevoEntrega : Form
    {
        CN_NuevoEntrega objetoCN = new CN_NuevoEntrega();
        ReportDataSource rs = new ReportDataSource();
        string[] array_estados = { "PENDIENTE", "EN PROCESO", "FINALIZADO" };
        private bool editar = false;
        private string no_entrega = null;
        private string estado = null;
        private string fecha = null;

        public Frm_NuevoEntrega()
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

        public void MostrarNuevoEntregas()
        {
            CN_NuevoEntrega objetoCN = new CN_NuevoEntrega();
            dgvEntregas.DataSource = objetoCN.MostrarNuevoEntregas("TODOS", "");
        }

        public void LimpiarTextBox()
        {
            txtTicket.Clear();
            txtCliente.Clear();
            txtSerie.Clear();
            txtTecnico.Clear();
            txtTrabajo.Clear();
            txtRepuesto.Clear();
            txtGarantia.Clear();
            txtBusqueda.Clear();
        }

        private void Frm_Entrega_Load(object sender, EventArgs e)
        {
            MostrarNuevoEntregas();
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
                    objetoCN.InsertarNuevoEntregas(txtTicket.Text, txtCliente.Text, txtSerie.Text, txtTecnico.Text, cmbEstado.SelectedIndex + 1, dtFecha.Value.Date.ToString("dd/MM/yyyy"), txtTrabajo.Text, txtRepuesto.Text, txtGarantia.Text);
                    MessageBox.Show("Guardado con exito");
                    MostrarNuevoEntregas();
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
                    objetoCN.EditarNuevoEntregas(txtTicket.Text, txtCliente.Text, txtSerie.Text, txtTecnico.Text, cmbEstado.SelectedIndex + 1, dtFecha.Value.Date.ToString("dd/MM/yyyy"), txtTrabajo.Text, txtRepuesto.Text, txtGarantia.Text, no_entrega);
                    MessageBox.Show("Edito con exito");
                    MostrarNuevoEntregas();
                    LimpiarTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se guardo la informacion por: " + ex);
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
          
            if (dgvEntregas.SelectedRows.Count > 0)
            {
                editar = true;
                txtTicket.Text = dgvEntregas.CurrentRow.Cells["No. Ticket"].Value.ToString();
                txtCliente.Text = dgvEntregas.CurrentRow.Cells["No. Cliente"].Value.ToString();
                txtSerie.Text = dgvEntregas.CurrentRow.Cells["No. Serie"].Value.ToString();
                txtTecnico.Text = dgvEntregas.CurrentRow.Cells["No. Tecnico Asignado"].Value.ToString();

                estado = dgvEntregas.CurrentRow.Cells["Estado"].Value.ToString();
                cmbEstado.Text = estado;

                fecha = dgvEntregas.CurrentRow.Cells["Fecha de ingreso"].Value.ToString();
                dtFecha.Text = fecha;
                fecha = dtFecha.Value.Date.ToShortDateString();

                txtTrabajo.Text = dgvEntregas.CurrentRow.Cells["Trabajo realizado"].Value.ToString();
                txtRepuesto.Text = dgvEntregas.CurrentRow.Cells["Repuestos utilizados"].Value.ToString();
                txtGarantia.Text = dgvEntregas.CurrentRow.Cells["Garantia"].Value.ToString();
                no_entrega = dgvEntregas.CurrentRow.Cells["No. Entrega"].Value.ToString();
            }
            else
                MessageBox.Show("Por favor selecione una fila");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEntregas.SelectedRows.Count > 0)
            {
                no_entrega = dgvEntregas.CurrentRow.Cells["No. Entrega"].Value.ToString(); ;
                objetoCN.EliminarEntregas(no_entrega);
                MessageBox.Show("Elimino con exito");
                MostrarNuevoEntregas();
            }
            else
            {
                MessageBox.Show("Por favor selecione una fila");
            }
        }

        private void gpbTablaCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvEntregas.SelectedRows.Count > 0)
            {
                no_entrega = dgvEntregas.CurrentRow.Cells["No. Entrega"].Value.ToString();

                FrmEntregaReport generarEntrega = new FrmEntregaReport(no_entrega);
                MessageBox.Show("Generando entrega");
                generarEntrega.ShowDialog();
                MostrarNuevoEntregas();
                LimpiarTextBox();

            }
            else
            {
                MessageBox.Show("Por favor selecione una fila");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CN_NuevoEntrega objetoCN = new CN_NuevoEntrega();
            dgvEntregas.DataSource = objetoCN.MostrarNuevoEntregas(cmbFiltrado.Text, txtBusqueda.Text);
            LimpiarTextBox();
        }
    }
}
