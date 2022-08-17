using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_N_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lstMensajes.SelectedIndex;
            lblMensaje.Text = lstMensajes.Items[indice].ToString();
        }

        private void chkHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitar.Checked)
            {
                txtNuevoMensaje.Visible = true;
                btnAgregar.Visible = true;
            }
            else
            {
                txtNuevoMensaje.Visible = false;
                btnAgregar.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstMensajes.Items.Add(txtNuevoMensaje.Text);
        }
    }
}
