﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class GZNPrincipal : Form
    {
        public GZNPrincipal()
        {
            InitializeComponent();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menufuncionários_Click(object sender, EventArgs e)
        {
            cadastro.GZNFuncionarios frm = new cadastro.GZNFuncionarios();
            frm.ShowDialog();
        }

        private void MenuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menucargos_Click(object sender, EventArgs e)
        {
            cadastro.FrmCargo frm = new cadastro.FrmCargo();
            frm.ShowDialog();
        }

        private void Menuclientes_Click(object sender, EventArgs e)
        {
            cadastro.FrmCliente frm = new cadastro.FrmCliente();
            frm.ShowDialog();
        }
    }
}
