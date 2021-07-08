using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication1
{
      public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e) // search
        {
            try
            {
                way = textBox6.Text;
                alm = 0;

                aws = new noname();

                y = textBox2.Text + "~" + textBox3.Text + "~" + textBox4.Text + "~" + textBox5.Text + "~" + textBox7.Text + "~" + textBox8.Text + "~" + textBox9.Text;
                pm = aws.find(y.Split('~'), way);

                textBox2.Text = pm.Split('~')[alm];
                textBox3.Text = pm.Split('~')[alm + 1];
                textBox4.Text = pm.Split('~')[alm + 2];
                textBox5.Text = pm.Split('~')[alm + 3];
                textBox7.Text = pm.Split('~')[alm + 4];
                textBox8.Text = pm.Split('~')[alm + 5];
                textBox9.Text = pm.Split('~')[alm + 6];
                textBox1.Text = pm.Split('~')[alm + 7] + "/" + pm.Split('~')[pm.Split('~').Length - 1];
                if (pm.Split('~').Length > 8)
                {
                    button4.Enabled = true;
                }

                alm = 0;
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
            }

        private void button5_Click(object sender, EventArgs e) // add
        {
            try
            {
                way = textBox6.Text;
                aws = new noname();
                y = textBox2.Text + "~" + textBox3.Text + "~" + textBox4.Text + "~" + textBox5.Text + "~" + textBox7.Text + "~" + textBox8.Text + "~" + textBox9.Text;
                aws.add(y, way);
                System.Windows.Forms.MessageBox.Show("entry added");
                y = string.Empty;
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
                System.Windows.Forms.MessageBox.Show("sorry, can't do that");
            }
            finally
            {

            }

            }

        private void button3_Click(object sender, EventArgs e) // delete
        {
            try
            {
                way = textBox6.Text;
                aws = new noname();

                y = textBox2.Text + "~" + textBox3.Text + "~" + textBox4.Text + "~" + textBox5.Text + "~" + textBox7.Text + "~" + textBox8.Text + "~" + textBox9.Text;
                aws.delete(y, way);

                System.Windows.Forms.MessageBox.Show("entry deleted");
                y = string.Empty;
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
            }

        private void button7_Click(object sender, EventArgs e) // rewrite
        {
            try
            {
                way = textBox6.Text;
                aws = new noname();
                y = textBox2.Text + "~" + textBox3.Text + "~" + textBox4.Text + "~" + textBox5.Text + "~" + textBox7.Text + "~" + textBox8.Text + "~" + textBox9.Text;
                aws.rewrite(y, way);
                System.Windows.Forms.MessageBox.Show("file rewritten");
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) // full_clean
        {
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                y = string.Empty;
                alm = 0;
                button4.Enabled = false;
                button6.Enabled = false;
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e) // +
        {
            try
            {
                if (alm + 14 > pm.Split('~').Length)
                {
                    button4.Enabled = false;
                }
                else
                {
                    alm = alm + 8;
                    textBox2.Text = pm.Split('~')[alm];
                    textBox3.Text = pm.Split('~')[alm + 1];
                    textBox4.Text = pm.Split('~')[alm + 2];
                    textBox5.Text = pm.Split('~')[alm + 3];
                    textBox7.Text = pm.Split('~')[alm + 4];
                    textBox8.Text = pm.Split('~')[alm + 5];
                    textBox9.Text = pm.Split('~')[alm + 6];
                    textBox1.Text = pm.Split('~')[alm + 7] + "/" + pm.Split('~')[pm.Split('~').Length - 1];
                }
                if (alm - 8 >= 0)
                {
                    button6.Enabled = true;
                }
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e) // -
        {
            try
            {
                alm = alm - 8;
                textBox2.Text = pm.Split('~')[alm];
                textBox3.Text = pm.Split('~')[alm + 1];
                textBox4.Text = pm.Split('~')[alm + 2];
                textBox5.Text = pm.Split('~')[alm + 3];
                textBox7.Text = pm.Split('~')[alm + 4];
                textBox8.Text = pm.Split('~')[alm + 5];
                textBox9.Text = pm.Split('~')[alm + 6];
                textBox1.Text = pm.Split('~')[alm + 7] + "/" + pm.Split('~')[pm.Split('~').Length - 1];

                if (alm + 14 <= pm.Split('~').Length)
                {
                    button4.Enabled = true;
                }

                if (alm - 8 < 0)
                {
                    button6.Enabled = false;
                }
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
            }

        private void button9_Click(object sender, EventArgs e) // delete file
        {
            try
            { 
                way = textBox6.Text;
                File.Delete(way);
                System.Windows.Forms.MessageBox.Show("file irretrievably deleted");
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
                System.Windows.Forms.MessageBox.Show("there's a problem with deleting this file but it's not my fault");
            }
        }

        private void Form1_Load(object sender, EventArgs e) // onload
        {
            try
            {
                way = textBox6.Text;

                if (!File.Exists(way))
                {
                    aws = new noname();
                    aws.create(way);
                    System.Windows.Forms.MessageBox.Show("new file created");

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("file already exists");

                    aws = new noname();
                    pm = aws.outcome(way);

                    textBox2.Text = pm.Split('~')[alm];
                    textBox3.Text = pm.Split('~')[alm + 1];
                    textBox4.Text = pm.Split('~')[alm + 2];
                    textBox5.Text = pm.Split('~')[alm + 3];
                    textBox7.Text = pm.Split('~')[alm + 4];
                    textBox8.Text = pm.Split('~')[alm + 5];
                    textBox9.Text = pm.Split('~')[alm + 6];
                    textBox1.Text = pm.Split('~')[alm + 7] + "/" + pm.Split('~')[pm.Split('~').Length - 1];

                }

                button4.Enabled = true;
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
                System.Windows.Forms.MessageBox.Show("somehow it all went terribly wrong...");
            }
            finally
            { }
        }

        private void button10_Click(object sender, EventArgs e) // create file
        {
            way = textBox6.Text;
            aws = new noname();
            aws.create(way);
            System.Windows.Forms.MessageBox.Show("new file created");
        }

        private void button8_Click(object sender, EventArgs e) // show all entries НЕОБЯЗАТЕЛЬНО
        {
            try
            {
                way = textBox6.Text;
                aws = new noname();
                pm = aws.outcome(way);

                textBox2.Text = pm.Split('~')[alm];
                textBox3.Text = pm.Split('~')[alm + 1];
                textBox4.Text = pm.Split('~')[alm + 2];
                textBox5.Text = pm.Split('~')[alm + 3];
                textBox7.Text = pm.Split('~')[alm + 4];
                textBox8.Text = pm.Split('~')[alm + 5];
                textBox9.Text = pm.Split('~')[alm + 6];
                textBox1.Text = pm.Split('~')[alm + 7] + "/" + pm.Split('~')[pm.Split('~').Length - 1];
                button4.Enabled = true;
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
            finally
            { }
            } 

        
    

    
    
    
    }
}