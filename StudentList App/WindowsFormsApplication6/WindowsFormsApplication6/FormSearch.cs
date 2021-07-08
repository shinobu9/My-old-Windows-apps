using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
            tt = new datafind(Properties.Settings.Default.Data2ConnectionString);
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.

            foreach (string s in tt.listfiller(textBox1.Text))
            {
                listBox1.Text += s;
                progressBar1.Step += 1;
            }
        }

        
    }
}
