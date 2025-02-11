﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Cache;
// Libreria para poder arrastar la pantalla
using System.Runtime.InteropServices;

namespace Service_Desk_NP
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            personalizar();
        }

        private void LoadDatosUsuario()
        {
            lblNombre.Text = UsuarioLoginCache.nombre_usuario + " " + UsuarioLoginCache.apellido_usuario;
            lblPuesto.Text = UsuarioLoginCache.puesto_usuario;
            lblCorreo.Text = UsuarioLoginCache.correo_usuario;
        }
        
  
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Boton para expandir o contraer el menu
        private void BtnSlide_Click(object sender, EventArgs e)
        {
            /* (menuVertical.Width == 294)
            {
                menuVertical.Width = 90;
            }
            else
                menuVertical.Width = 294;*/
        }
        //  Boton para cerrar la pantalla
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar el programa?", "¡CUIDADO!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        // Boton para expandir la pantalla
        private void BtnExpandir_Click(object sender, EventArgs e)
        {
            /*this.WindowState = FormWindowState.Maximized;
            btnContraer.Visible = true;
            btnExpandir.Visible = false;*/
        }
        // Boton para contraer o restaurar la pantalla a su posicion original
        private void BtnContraer_Click(object sender, EventArgs e)
        {
            /*this.WindowState = FormWindowState.Normal;
            btnContraer.Visible = false;
            btnExpandir.Visible = true;*/
        }
        // Boton para minimizar la pantalla 
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Permitir accion de arratrar el formulario
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Funcion para enlazar formularios en el Formulario Principal
        private Form formActivo = null;

        private void AbrirFormEnPrincipal(Form FormSecundario)
        {
           if (formActivo!= null)
                formActivo.Close();
            formActivo = FormSecundario;
            FormSecundario.TopLevel = false;
            FormSecundario.FormBorderStyle = FormBorderStyle.None;
            FormSecundario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(FormSecundario);
            panelContenedor.Tag = FormSecundario;
            FormSecundario.BringToFront();
            FormSecundario.Show();
            
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPrincipal(new FrmCliente());
            hideSubmenu();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            AbrirFormEnPrincipal(new FrmInicio());
            hideSubmenu();
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPrincipal(new FrmEquipo());
            hideSubmenu();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            AbrirFormEnPrincipal(new Presentacion.Frm_NuevoTicket());
            hideSubmenu();
        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            AbrirFormEnPrincipal(new FrmTecnico());
            hideSubmenu();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar sesión?", "¡CUIDADO!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            this.Close();
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            AbrirFormEnPrincipal(new Presentacion.Frm_NuevoEntrega());
            hideSubmenu();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LoadDatosUsuario();
        }

        public void personalizar()
        {
            panelSubMenuServicios.Visible = false;
        }

        public void hideSubmenu()
        {
            if(panelSubMenuServicios.Visible == true)
            {
                panelSubMenuServicios.Visible = false;
            }
        }

        public void showSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                hideSubmenu();
                Submenu.Visible = true;
            }
            else 
                Submenu.Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
           
            showSubmenu(panelSubMenuServicios);
        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPrincipal(new Presentacion.Frm_Info_Pendiente());
            hideSubmenu();
        }

        private void btnProceso_Click(object sender, EventArgs e)
        {
            AbrirFormEnPrincipal(new Presentacion.Frm_Info_Proceso());
            hideSubmenu();
        }

        private void btnFinalizado_Click(object sender, EventArgs e)
        {
            AbrirFormEnPrincipal(new Presentacion.Frm_Info_Finalizar());
            hideSubmenu();
        }

      
    }
}
