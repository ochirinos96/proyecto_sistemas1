using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinApp1
{
    public partial class editar : Form
    {
        public editar()
        {
            InitializeComponent();
        }

        public string it;
        public string desc;
        public editar(string item,string descripcion)
        {
            InitializeComponent();
            it = item;
            desc = descripcion;
        }

        private void editar_Load(object sender, EventArgs e)
        {
            txtitem.Text = it;
            txtdesc.Text = desc;

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
