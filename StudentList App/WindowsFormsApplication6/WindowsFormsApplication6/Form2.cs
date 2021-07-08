using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ed1 = new data3(Properties.Settings.Default.Data2ConnectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            data2DataSet7.Clear();
            this.aDNTableAdapter.Fill(this.data2DataSet7.ADN,Properties.Settings.Default.CurrentStudent);
            Form1.ActiveForm.Enabled = false;
         }

        private void button1_Click(object sender, EventArgs e)//ADD
        {
            ed1.insert_3(textBox1.Text, textBox2.Text, textBox3.Text);
            data2DataSet7.Clear();
            this.aDNTableAdapter.Fill(this.data2DataSet7.ADN, Properties.Settings.Default.CurrentStudent);
        }

        private void button2_Click(object sender, EventArgs e)//UPDATE
        {
            Properties.Settings.Default.CurrentParent = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ed1.update_3(textBox1.Text, textBox2.Text, textBox3.Text);
            //ed1.update_3(dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString());
            data2DataSet7.Clear();
            this.aDNTableAdapter.Fill(this.data2DataSet7.ADN, Properties.Settings.Default.CurrentStudent);
        }

        private void button3_Click(object sender, EventArgs e)//DELETE
        {
            ed1.delete_3(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            data2DataSet7.Clear();
            this.aDNTableAdapter.Fill(this.data2DataSet7.ADN, Properties.Settings.Default.CurrentStudent);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

       
    }
}
