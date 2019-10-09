using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Libreria para poder arrastar la pantalla
using System.Runtime.InteropServices;

namespace Service_Desk_NP
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
           
        }
        
        // Mensajes de ayuda para el ususurio 
       


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Boton para expandir o contraer el menu
        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 310)
            {
                menuVertical.Width = 90;
            }
            else
                menuVertical.Width = 310;
        }
        //  Boton para cerrar la pantalla
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Boton para expandir la pantalla
        private void BtnExpandir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnContraer.Visible = true;
            btnExpandir.Visible = false;
        }
        // Boton para contraer o restaurar la pantalla a su posicion original
        private void BtnContraer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnContraer.Visible = false;
            btnExpandir.Visible = true;
        }
        // Boton para minimizar la pantalla 
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
