using System.Collections;
using System.IO;
using System;
namespace WindowsFormsApplication1
{
    public class noname
    {
        public StreamReader rrr = null;
        public StreamWriter www = null;
        public ArrayList arr = null;
        public ArrayList ttt = null;
        public ArrayList fff = null;

        string sss = string.Empty;

        //-------------------------------------------------

        public noname()
        {

        }

        public int FindPattern(string a, string b)
        {
            int q = 0;
            string n = string.Empty;

            for (int x = 0; x < Nelength(a); x++)
            {
                if (x + Nelength(b) < Nelength(a))
                {
                    for (int y = x; y < x + Nelength(b); y++)
                    {

                        n += a[y];
                    }
                }

                if (n == b)
                {
                    q++;
                }

                n = string.Empty;
            }

            return q;
        }

        public int Nelength(string u)
        {
            int x = 0;

            foreach (char c in u)
            {
                x++;
            }

            return x;
        }

        public void add(string yyy, string way)
        {
            try
            {
                arr = new ArrayList();
                rrr = new StreamReader(way);

                while ((sss = rrr.ReadLine()) != null)
                {
                    arr.Add(sss);
                }

            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
                System.Windows.Forms.MessageBox.Show("this file is empty. use the REWRITE button this first time");
            }
            finally
            {
                rrr.Close();
            }

            try
            {
                www = new StreamWriter (way);

                arr.Add(yyy);

                foreach (string s in arr)
                {
                    www.WriteLine(s);
                }
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
            finally
            {
                www.Flush();
                www.Close();

            }
        } //done

        public void rewrite(string yyy, string way)
        {  
            try
            {
                www = new StreamWriter(way);
                www.WriteLine(yyy);
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
            finally
            {
                www.Flush();
                www.Close();

            }
            
        } //done

        public void delete(string yyy, string way)
        {
            string i = string.Empty;
            string r = string.Empty;

            //---------------send info from a file to massive----------
            try
            {
                arr = new ArrayList();
                rrr = new StreamReader(way);

                while ((sss = rrr.ReadLine()) != null)
                {
                    arr.Add(sss);
                }

                arr.Remove(yyy);
                
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
            finally
            {
                rrr.Close();
            }
            //----------------------------------------------------------

            //------------writing down------------
            try
            {
                www = new StreamWriter(way);

                foreach (string s in arr)
                {
                    www.WriteLine(s);
                }
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
            finally
            {
                www.Flush();
                www.Close();
            }
            //--------------------------------------------------------
        }

        public string find(string[] yyy, string way)
        {           
//--------------reading from the source------------------------------------------
        try
            {
                arr = new ArrayList();
                rrr = new StreamReader(way);

                while ((sss = rrr.ReadLine()) != null)
                {
                    arr.Add(sss);
                }

            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
            finally
            {
                rrr.Close();
            }            
//------------actually searching-------------------------------------------------
        string j = string.Empty;
        ttt = new ArrayList(yyy);
           int q = 0;
           int d = 0;
                 
                      foreach (string r in arr)
                      {
                          q = 0;

                          foreach (string s in ttt)
                          { 
                              if (FindPattern(r, s) < 1)
                              {
                                  break;
                              }
                              else
                              {
                                  q++;
                              }
                          }
                  
                            if (q >= yyy.Length)
                                {
                                    d++;
                                    j = j + r + "~" + d.ToString() + "~";
                                }
                       }
           
          //-------------returning---------------------------------------------------------
                      if (d == 0)
                      {
                          j = "-~-~-~-~-~-~-";
                      }
                      else
                      {
                          j = j + d.ToString();
                      }
                      
                 return j;
            
        }

        public string outcome(string way)
        {
            try
            {
                arr = new ArrayList();
                rrr = new StreamReader(way);

                while ((sss = rrr.ReadLine()) != null)
                {
                    arr.Add(sss);
                }
                
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
            finally
            {
                rrr.Close();
            }

            string m = string.Empty;
            int d = 0;

            foreach (string s in arr)
            {
                m = m + arr[d].ToString();
                d++;
                m = m + "~" + d.ToString() + "~";
            }

            m = m + d.ToString();

            return m;
        } //done

        public void create(string way)
        {
            try
            {
                www = new StreamWriter(way);
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
            finally
            {
                www.Flush();
                www.Close();

            }
        }

}//закрывает noname

    

    partial class Form1
    {
        private noname aws = null;
        string y = string.Empty;
        int alm = 0;
        string pm = string.Empty;
        string way = string.Empty; // используется только для адресов

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(224, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(53, 13);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Имя";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Отчество";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Телефон";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 145);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(370, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "delete entry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(370, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "add entry";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "full_clean";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(149, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 24);
            this.button4.TabIndex = 24;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(176, 126);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 24);
            this.button6.TabIndex = 25;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(284, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "rewrite file";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(301, 125);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 20);
            this.textBox6.TabIndex = 27;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(284, 76);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 30;
            this.button9.Text = "delete file";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Страна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Город";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Почтовый индекс";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(150, 24);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 31;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(150, 63);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 20);
            this.textBox8.TabIndex = 33;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(150, 102);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(121, 20);
            this.textBox9.TabIndex = 36;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(284, 47);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 38;
            this.button10.Text = "create file";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "адресная строка";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(213, 153);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 23);
            this.button8.TabIndex = 40;
            this.button8.Text = "show all entries";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(462, 188);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "data 2.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
    }
}

