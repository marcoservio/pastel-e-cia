﻿using PastelECia.Views.Cadastro;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastelECia.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
            sobre.Dispose();
        }

        private void testeBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTesteCodigo f = new frmTesteCodigo();
            f.Dock = DockStyle.Fill;

            TabPage tb = new TabPage();
            tb.Name = "Teste de Codigo";
            tb.Text = "Teste de Codigo";
            tb.ImageIndex = 0;
            tb.Controls.Add(f);
            tbcAplicacoes.TabPages.Add(tb);
        }

        private void testeAncestralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAncestral f = new frmAncestral();
            f.Dock = DockStyle.Fill;

            TabPage tb = new TabPage();
            tb.Name = "Teste Ancestral";
            tb.Text = "Teste Ancestral";
            tb.ImageIndex = 0;
            tb.Controls.Add(f);
            tbcAplicacoes.TabPages.Add(tb);
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            f.Dock = DockStyle.Fill;

            TabPage tb = new TabPage();
            tb.Name = "Cadastro Produto";
            tb.Text = "Cadastro Produto";
            tb.ImageIndex = 0;
            tb.Controls.Add(f);
            tbcAplicacoes.TabPages.Add(tb);
        }
    }
}