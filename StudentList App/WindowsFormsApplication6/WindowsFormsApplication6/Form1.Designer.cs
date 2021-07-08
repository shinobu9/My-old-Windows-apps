using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using System;
namespace WindowsFormsApplication6
{
    public class data2
    {
        public string cnstr = string.Empty;

        public data2(string datacon)
        {
            cnstr = datacon;
        }

        public SqlConnection cn = null;
        public SqlCommand comm = null;
        public SqlDataReader rd = null;
        
        public int count_2()
            {
                object obj = null;
                int rez = 0;
                try
                {
                    cn = new SqlConnection(cnstr);
                   // comm = new SqlCommand("Select COUNT(*) from [STN]", cn);
                    comm = new SqlCommand("[dbo].[Count2]", cn);
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    cn.Open();
                    obj = comm.ExecuteScalar();

                    if (obj != null)
                    {
                        if (Convert.ToInt32(obj) > 0)
                        {
                            rez = Convert.ToInt32(obj);
                        }
                    }
                }
                catch (Exception exx)
                {
                    System.Diagnostics.Debug.WriteLine(exx.Message);
                }
                finally
                {
                    cn.Close();
                }
                return rez;
            }

        public void insert_2(ArrayList ins, object insdt)
        {
            int r = 0;
            try
            {
                cn = new SqlConnection(cnstr);
                
              //  comm = new SqlCommand("insert into [STN]([LName],[FName],[SName],[School],[Class],[Tel],[EMail],[Date]) values(@LN,@FN,@SN,@SC,@C,@T,@E,@D)", cn);
                comm = new SqlCommand("[dbo].[insert2]", cn);
     
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@LN", ins[0]);
                comm.Parameters.AddWithValue("@FN", ins[1]);
                comm.Parameters.AddWithValue("@SN", ins[2]);
                comm.Parameters.AddWithValue("@SC", ins[3]);
                comm.Parameters.AddWithValue("@C", ins[4]);
                comm.Parameters.AddWithValue("@T", ins[5]);
                comm.Parameters.AddWithValue("@E", ins[6]);
                comm.Parameters.AddWithValue("@D", insdt);
                
                cn.Open();
                r = comm.ExecuteNonQuery();
            }
            catch (Exception exx)
            {
                System.Diagnostics.Debug.WriteLine(exx.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void delete_2(string id)
        {
            try
            {
                cn = new SqlConnection(cnstr);
              //  comm = new SqlCommand("delete from [STN] where [ID]=@id", cn);
                comm = new SqlCommand("[dbo].[Delete2]",cn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@id", id);
                cn.Open();
                int r = comm.ExecuteNonQuery();
            }
            catch (Exception exx)
            {
                System.Diagnostics.Debug.WriteLine(exx.Message);
            }
            finally { cn.Close(); }
        }

        public void update_2(string id, ArrayList del, object updt)
        {
            try
            {
                cn = new SqlConnection(cnstr);
              //  comm = new SqlCommand("update [STN] set [FName] = @FN, [LName] = @LN,[Sname] = @SN,[School]=@SC,[Class]=@C, [Tel] = @T,[EMail]=@E,[Date]=@D where [ID] = @ID", cn);
                comm = new SqlCommand("[dbo].[Update2]",cn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@ID", id);
                comm.Parameters.AddWithValue("@LN", del[0]);
                comm.Parameters.AddWithValue("@FN", del[1]);
                comm.Parameters.AddWithValue("@SN", del[2]);
                comm.Parameters.AddWithValue("@SC", del[3]);
                comm.Parameters.AddWithValue("@C", del[4]);
                comm.Parameters.AddWithValue("@T", del[5]);
                comm.Parameters.AddWithValue("@E", del[6]);
                comm.Parameters.AddWithValue("@D", updt);
                cn.Open();
                int r = comm.ExecuteNonQuery();
            }
            catch (Exception exx)
            {
                System.Diagnostics.Debug.WriteLine(exx.Message);
            }
            finally { cn.Close(); }
        }

        public void backup(string id)
        {
            ArrayList asd = new ArrayList();
            //========== reads from STN =========================
            try
            {
                cn = new SqlConnection(cnstr);
                comm = new SqlCommand("[dbo].[copyinSTN]", cn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@ID", id);
                cn.Open();
                rd = comm.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        asd.Add(rd[1].ToString() + "~" + rd[2].ToString() + "~" + rd[3].ToString() + "~" + rd[4].ToString() + "~" + rd[5].ToString() + "~" + rd[6].ToString() + "~" + rd[7].ToString() + "~" + rd[8].ToString());
                    }
                }
            }
            catch (Exception exx)
            {
                System.Diagnostics.Debug.WriteLine(exx.Message);
            }
            finally
            {
                cn.Close();
                rd.Close();
            }
            //============ reads from ADN ===========================
        //    ArrayList zxc = new ArrayList(); // 4 ADN
            try
            {
                cn = new SqlConnection(cnstr);
                comm = new SqlCommand("[dbo].[copyinADN]", cn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@ID", id);
                cn.Open();
                rd = comm.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        asd.Add(rd[2].ToString() + "~" + rd[3].ToString() + "~" + rd[4].ToString());
                    }
                }
            }
            catch (Exception exx)
            {
                System.Diagnostics.Debug.WriteLine(exx.Message);
            }
            finally
            {
                cn.Close();
                rd.Close();
            }
            //============= writes into BACKUP =========================
            try
            {
                //------------------------------------------
                    string n = string.Empty;
                    string t = string.Empty;
                    string a = string.Empty;

                    if (asd.Count > 1)
                    {
                        for (int x = 1; x < asd.Count; x++)
                        {
                            if (x != asd.Count-1)
                            {
                                n += asd[x].ToString().Split('~')[0] + ", ";
                                t += asd[x].ToString().Split('~')[1] + ", ";
                                a += asd[x].ToString().Split('~')[2] + ", ";
                            }
                            else
                            {
                                n += asd[x].ToString().Split('~')[0];
                                t += asd[x].ToString().Split('~')[1];
                                a += asd[x].ToString().Split('~')[2];
                            }
                        }
                    }
                //------------------------------------------
                cn = new SqlConnection(cnstr);
                comm = new SqlCommand("[dbo].[insin]", cn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@LN", asd[0].ToString().Split('~')[0]);
                comm.Parameters.AddWithValue("@FN", asd[0].ToString().Split('~')[1]);
                comm.Parameters.AddWithValue("@SN", asd[0].ToString().Split('~')[2]);
                comm.Parameters.AddWithValue("@SC", asd[0].ToString().Split('~')[3]);
                comm.Parameters.AddWithValue("@C", asd[0].ToString().Split('~')[4]);
                comm.Parameters.AddWithValue("@T", asd[0].ToString().Split('~')[5]);
                comm.Parameters.AddWithValue("@E", asd[0].ToString().Split('~')[6]);
                comm.Parameters.AddWithValue("@D", asd[0].ToString().Split('~')[7]);
                comm.Parameters.AddWithValue("@yn", n);
                comm.Parameters.AddWithValue("@yt", t);
                comm.Parameters.AddWithValue("@ya", a);
                cn.Open();
                int r = comm.ExecuteNonQuery();
            }
            catch (Exception eee)
            {
                System.Diagnostics.Debug.WriteLine(eee.Message);
            }
            finally
            {
                cn.Close();
            }
            
        }
    }


    partial class Form1
    {
        public data2 ed = null;

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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.School = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data2DataSet4 = new WindowsFormsApplication6.Data2DataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sTNTableAdapter1 = new WindowsFormsApplication6.Data2DataSet4TableAdapters.STNTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2DataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(271, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(414, 35);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 20);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ВСЕГО ЗАПИСЕЙ: 0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(547, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(60, 20);
            this.textBox5.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(861, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "ДОБАВИТЬ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(861, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "УДАЛИТЬ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(861, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 36);
            this.button4.TabIndex = 10;
            this.button4.Text = "ИЗМЕНИТЬ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.LName,
            this.FName,
            this.SName,
            this.School,
            this.Class,
            this.Tel,
            this.EMail,
            this.Date});
            this.dataGridView1.DataSource = this.sTNBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(843, 311);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // LName
            // 
            this.LName.DataPropertyName = "LName";
            this.LName.HeaderText = "Фамилия";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "FName";
            this.FName.HeaderText = "Имя";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // SName
            // 
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "Отчество";
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            // 
            // School
            // 
            this.School.DataPropertyName = "School";
            this.School.HeaderText = "Школа";
            this.School.Name = "School";
            this.School.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.DataPropertyName = "Class";
            this.Class.HeaderText = "Класс";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Телефон";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // EMail
            // 
            this.EMail.DataPropertyName = "EMail";
            this.EMail.HeaderText = "EMail";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата зачисления";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // sTNBindingSource
            // 
            this.sTNBindingSource.DataMember = "STN";
            this.sTNBindingSource.DataSource = this.data2DataSet4;
            // 
            // data2DataSet4
            // 
            this.data2DataSet4.DataSetName = "Data2DataSet4";
            this.data2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "ОЧИСТИТЬ ВСЕ ПОЛЯ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Школа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Телефон";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(13, 77);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(126, 20);
            this.textBox6.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Класс";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(145, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(153, 20);
            this.textBox7.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "e-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Дата";
            // 
            // sTNTableAdapter1
            // 
            this.sTNTableAdapter1.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(860, 373);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 37);
            this.button5.TabIndex = 26;
            this.button5.Text = "УДАЛЕННЫЕ ЗАПИСИ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(859, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 36);
            this.button6.TabIndex = 28;
            this.button6.Text = "ПОИСК";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(0, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 117);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(952, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Ученики";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2DataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Data2DataSet4 data2DataSet4;
        private System.Windows.Forms.BindingSource sTNBindingSource;
        private WindowsFormsApplication6.Data2DataSet4TableAdapters.STNTableAdapter sTNTableAdapter1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn School;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

