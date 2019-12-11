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
using Presentacion;
using Soporte.Cache;
using Service_Desk_NP;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "CONTRASEÑA")
            {
                txtClave.Text = "";
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "CONTRASEÑA";
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar el programa?", "¡CUIDADO!",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO") 
            {
                if (txtClave.Text != "CONTRASEÑA") 
                {
                    CN_Usuario usuario = new CN_Usuario();
                    var loginValido = usuario.Inicio_Sesion(txtUsuario.Text, txtClave.Text);
                    if (loginValido == true)
                    {
                        FrmPrincipal menuPrincipal = new FrmPrincipal();
                        MessageBox.Show("Bienvenido " + UsuarioLoginCache.nombre_usuario + " " + UsuarioLoginCache.apellido_usuario);
                        //MessageBoxIcon.Information;
                        menuPrincipal.Show();
                        menuPrincipal.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Error al iniciar sesión usuario o contraseña incorrectos. \n     Por favor intente de nuevo.");
                        txtClave.Text = "CONTRASEÑA";
                        txtUsuario.Focus();
                    }
                }
                else msgError("Por favor ingrese su contraseña.");
            }
            else msgError("Por favor ingrese nombre de usuario.");
        }

        public void msgError(string msg)
        {
            lblMensajeError.Text = "     " + msg;
            lblMensajeError.Visible = true;
        }

        public void Logout (object sender, FormClosedEventArgs e)
        {
            txtClave.Text = "CONTRASEÑA";
            txtClave.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblMensajeError.Visible = false;
            this.Show();
           
        }
    }
}
