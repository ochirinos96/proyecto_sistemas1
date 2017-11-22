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
    public partial class Form1 : Form, IAddItem
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formAdd = new Form2();
            formAdd.Show(this);

        }

        #region IAddItem Members

        public void AddNewItem(DataGridViewRow row)
        {
            string item = row.Cells["item"].Value.ToString();
            string desc = row.Cells["Desc"].Value.ToString();

            this.dataGridView1.Rows.Add(new []{ item, desc }); 

        }

        #endregion



        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }


    interface IAddItem
    {
        void AddNewItem(DataGridViewRow row);
    }

}
