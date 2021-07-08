namespace WindowsFormsApplication6
{
    partial class Form3
    {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stlnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stfnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stsnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stschoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bACKUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data2DataSet = new WindowsFormsApplication6.Data2DataSet();
            this.bACKUPTableAdapter = new WindowsFormsApplication6.Data2DataSetTableAdapters.BACKUPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bACKUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.stlnDataGridViewTextBoxColumn,
            this.stfnDataGridViewTextBoxColumn,
            this.stsnDataGridViewTextBoxColumn,
            this.stschoolDataGridViewTextBoxColumn,
            this.stclassDataGridViewTextBoxColumn,
            this.sttelDataGridViewTextBoxColumn,
            this.stemDataGridViewTextBoxColumn,
            this.stdateDataGridViewTextBoxColumn,
            this.adnameDataGridViewTextBoxColumn,
            this.adtelDataGridViewTextBoxColumn,
            this.adaddressDataGridViewTextBoxColumn,
            this.cDdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bACKUPBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(688, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // stlnDataGridViewTextBoxColumn
            // 
            this.stlnDataGridViewTextBoxColumn.DataPropertyName = "st_ln";
            this.stlnDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.stlnDataGridViewTextBoxColumn.Name = "stlnDataGridViewTextBoxColumn";
            this.stlnDataGridViewTextBoxColumn.ReadOnly = true;
            this.stlnDataGridViewTextBoxColumn.Width = 81;
            // 
            // stfnDataGridViewTextBoxColumn
            // 
            this.stfnDataGridViewTextBoxColumn.DataPropertyName = "st_fn";
            this.stfnDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.stfnDataGridViewTextBoxColumn.Name = "stfnDataGridViewTextBoxColumn";
            this.stfnDataGridViewTextBoxColumn.ReadOnly = true;
            this.stfnDataGridViewTextBoxColumn.Width = 54;
            // 
            // stsnDataGridViewTextBoxColumn
            // 
            this.stsnDataGridViewTextBoxColumn.DataPropertyName = "st_sn";
            this.stsnDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.stsnDataGridViewTextBoxColumn.Name = "stsnDataGridViewTextBoxColumn";
            this.stsnDataGridViewTextBoxColumn.ReadOnly = true;
            this.stsnDataGridViewTextBoxColumn.Width = 79;
            // 
            // stschoolDataGridViewTextBoxColumn
            // 
            this.stschoolDataGridViewTextBoxColumn.DataPropertyName = "st_school";
            this.stschoolDataGridViewTextBoxColumn.HeaderText = "Школа";
            this.stschoolDataGridViewTextBoxColumn.Name = "stschoolDataGridViewTextBoxColumn";
            this.stschoolDataGridViewTextBoxColumn.ReadOnly = true;
            this.stschoolDataGridViewTextBoxColumn.Width = 65;
            // 
            // stclassDataGridViewTextBoxColumn
            // 
            this.stclassDataGridViewTextBoxColumn.DataPropertyName = "st_class";
            this.stclassDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.stclassDataGridViewTextBoxColumn.Name = "stclassDataGridViewTextBoxColumn";
            this.stclassDataGridViewTextBoxColumn.ReadOnly = true;
            this.stclassDataGridViewTextBoxColumn.Width = 63;
            // 
            // sttelDataGridViewTextBoxColumn
            // 
            this.sttelDataGridViewTextBoxColumn.DataPropertyName = "st_tel";
            this.sttelDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.sttelDataGridViewTextBoxColumn.Name = "sttelDataGridViewTextBoxColumn";
            this.sttelDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttelDataGridViewTextBoxColumn.Width = 77;
            // 
            // stemDataGridViewTextBoxColumn
            // 
            this.stemDataGridViewTextBoxColumn.DataPropertyName = "st_em";
            this.stemDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.stemDataGridViewTextBoxColumn.Name = "stemDataGridViewTextBoxColumn";
            this.stemDataGridViewTextBoxColumn.ReadOnly = true;
            this.stemDataGridViewTextBoxColumn.Width = 58;
            // 
            // stdateDataGridViewTextBoxColumn
            // 
            this.stdateDataGridViewTextBoxColumn.DataPropertyName = "st_date";
            this.stdateDataGridViewTextBoxColumn.HeaderText = "Дата зачисления";
            this.stdateDataGridViewTextBoxColumn.Name = "stdateDataGridViewTextBoxColumn";
            this.stdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stdateDataGridViewTextBoxColumn.Width = 110;
            // 
            // adnameDataGridViewTextBoxColumn
            // 
            this.adnameDataGridViewTextBoxColumn.DataPropertyName = "ad_name";
            this.adnameDataGridViewTextBoxColumn.HeaderText = "Родители";
            this.adnameDataGridViewTextBoxColumn.Name = "adnameDataGridViewTextBoxColumn";
            this.adnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.adnameDataGridViewTextBoxColumn.Width = 80;
            // 
            // adtelDataGridViewTextBoxColumn
            // 
            this.adtelDataGridViewTextBoxColumn.DataPropertyName = "ad_tel";
            this.adtelDataGridViewTextBoxColumn.HeaderText = "Тел. родителей";
            this.adtelDataGridViewTextBoxColumn.Name = "adtelDataGridViewTextBoxColumn";
            this.adtelDataGridViewTextBoxColumn.ReadOnly = true;
            this.adtelDataGridViewTextBoxColumn.Width = 101;
            // 
            // adaddressDataGridViewTextBoxColumn
            // 
            this.adaddressDataGridViewTextBoxColumn.DataPropertyName = "ad_address";
            this.adaddressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adaddressDataGridViewTextBoxColumn.Name = "adaddressDataGridViewTextBoxColumn";
            this.adaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.adaddressDataGridViewTextBoxColumn.Width = 63;
            // 
            // cDdateDataGridViewTextBoxColumn
            // 
            this.cDdateDataGridViewTextBoxColumn.DataPropertyName = "CD_date";
            this.cDdateDataGridViewTextBoxColumn.HeaderText = "Дата удаления записи";
            this.cDdateDataGridViewTextBoxColumn.Name = "cDdateDataGridViewTextBoxColumn";
            this.cDdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDdateDataGridViewTextBoxColumn.Width = 134;
            // 
            // bACKUPBindingSource
            // 
            this.bACKUPBindingSource.DataMember = "BACKUP";
            this.bACKUPBindingSource.DataSource = this.data2DataSet;
            // 
            // data2DataSet
            // 
            this.data2DataSet.DataSetName = "Data2DataSet";
            this.data2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bACKUPTableAdapter
            // 
            this.bACKUPTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(688, 363);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Удаленные записи";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bACKUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Data2DataSet data2DataSet;
        private System.Windows.Forms.BindingSource bACKUPBindingSource;
        private WindowsFormsApplication6.Data2DataSetTableAdapters.BACKUPTableAdapter bACKUPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stlnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stfnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stsnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDdateDataGridViewTextBoxColumn;
    }
}