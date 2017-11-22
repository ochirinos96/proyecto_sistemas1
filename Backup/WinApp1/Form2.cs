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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.SelectedRows[0] as DataGridViewRow;


            IAddItem parent = this.Owner as IAddItem;
            parent.AddNewItem(row);

            this.Close();
        }


        public DataTable LoadGrid()
        {
            DataTable table = new DataTable();

            table.Columns.Add("item");
            table.Columns.Add("Desc");

            DataRow row1 = table.NewRow();
            row1["item"] = "item1";
            row1["Desc"] = "Desc1";
            table.Rows.Add(row1);

            DataRow row2 = table.NewRow();
            row2["item"] = "item2";
            row2["Desc"] = "Desc2";
            table.Rows.Add(row2);

            DataRow row3 = table.NewRow();
            row3["item"] = "item3";
            row3["Desc"] = "Desc3";
            table.Rows.Add(row3);

            return table;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.dataGridView1.DataSource = LoadGrid();
        }

    }
}
