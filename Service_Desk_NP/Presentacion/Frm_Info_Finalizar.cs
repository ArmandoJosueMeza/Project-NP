﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class Frm_Info_Finalizar : Form
    {
        CN_Info_Finalizado objetoCN = new CN_Info_Finalizado();

        public void MostrarFinalizados()
        {
            CN_Info_Finalizado objetoCN = new CN_Info_Finalizado();
            dgvFinalizados.DataSource = objetoCN.MostrarFinalizado();
        }
        public Frm_Info_Finalizar()
        {
            InitializeComponent();
        }

        private void Frm_Info_Finalizar_Load(object sender, EventArgs e)
        {
            MostrarFinalizados();
        }
    }
}
