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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ed = new data2(Properties.Settings.Default.Data2ConnectionString);
        }

        public ArrayList tt = new ArrayList();
        public object dat = new object();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data2DataSet4.STN' table. You can move, or remove it, as needed.
            this.sTNTableAdapter1.Fill(this.data2DataSet4.STN);
            label1.Text = "ВСЕГО ЗАПИСЕЙ: " + ed.count_2();
        } 

        private void button2_Click(object sender, EventArgs e) // INSERT
        {
            tt.Clear();
            tt.Add(textBox1.Text);
            tt.Add(textBox2.Text);
            tt.Add(textBox3.Text);
            tt.Add(textBox4.Text);
            tt.Add(textBox5.Text);
            tt.Add(textBox6.Text);
            tt.Add(textBox7.Text);
            dat = dateTimePicker1.Value.Date;

            ed.insert_2(tt,dat);
            data2DataSet4.Clear();
            this.sTNTableAdapter1.Fill(this.data2DataSet4.STN);
            label1.Text = "ВСЕГО ЗАПИСЕЙ: " + ed.count_2();
        }

        private void button3_Click(object sender, EventArgs e) // DELETE
        {
            string d = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ed.backup(d);
            ed.delete_2(d);
            data2DataSet4.Clear();
            this.sTNTableAdapter1.Fill(this.data2DataSet4.STN);
            label1.Text = "ВСЕГО ЗАПИСЕЙ: " + ed.count_2();
        }

        private void button4_Click(object sender, EventArgs e) // UPDATE
        {
            tt.Clear();
            tt.Add(textBox1.Text);
            tt.Add(textBox2.Text);
            tt.Add(textBox3.Text);
            tt.Add(textBox4.Text);
            tt.Add(textBox5.Text);
            tt.Add(textBox6.Text);
            tt.Add(textBox7.Text);
            dat = dateTimePicker1.Value.Date;

            ed.update_2(dataGridView1.CurrentRow.Cells[0].Value.ToString(), tt, dat);
            data2DataSet4.Clear();
            this.sTNTableAdapter1.Fill(this.data2DataSet4.STN);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e) // datagrid
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //textBox1.Text = data2DataSet4.Tables["STN"].Rows[int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())]["LName"].ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dateTimePicker1.Value = ((DateTime)dataGridView1.CurrentRow.Cells[8].Value);
                //dateTimePicker1.Value = ((DateTime)data2DataSet4.Tables["STN"].Rows[int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())]["Date"]);
            }
            catch (Exception eee)
                {
                    System.Diagnostics.Debug.WriteLine(eee.Message);
                }
        }

        private void button1_Click(object sender, EventArgs e) // CLEAR ALL
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) // SHOW PARENTS
        {
            Properties.Settings.Default.CurrentStudent = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Form2 fm = new Form2();
            fm.Show();
        }

        private void button5_Click(object sender, EventArgs e) // BACKUP
        {
            Form3 bup = new Form3();
            bup.Show();
        }

        private void button6_Click(object sender, EventArgs e) // SEARCH
        {
            FormSearch ss = new FormSearch();
            ss.Show();
        }

    }
}