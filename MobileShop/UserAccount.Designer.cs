namespace MobileShop
{
    partial class UserAccount
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textph = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.shopDataSet = new MobileShop.shopDataSet();
            this.userAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_AccountTableAdapter = new MobileShop.shopDataSetTableAdapters.User_AccountTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox4.Controls.Add(this.linkLabel5);
            this.groupBox4.Controls.Add(this.linkLabel4);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Location = new System.Drawing.Point(0, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(789, 57);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.LinkColor = System.Drawing.Color.White;
            this.linkLabel5.Location = new System.Drawing.Point(70, 19);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(41, 19);
            this.linkLabel5.TabIndex = 28;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Close";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkColor = System.Drawing.Color.White;
            this.linkLabel4.Location = new System.Drawing.Point(14, 19);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(43, 19);
            this.linkLabel4.TabIndex = 27;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Home";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::MobileShop.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(242, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 68);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textname);
            this.groupBox2.Controls.Add(this.textemail);
            this.groupBox2.Controls.Add(this.textph);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(18, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 174);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(432, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Owner",
            "Shopkeeper"});
            this.comboBox1.Location = new System.Drawing.Point(125, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 29);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(603, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(509, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(6, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 8;
            this.label12.Text = "User type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(3, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "User Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(381, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Phone Number";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(125, 31);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(226, 29);
            this.textname.TabIndex = 0;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(522, 81);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(215, 29);
            this.textemail.TabIndex = 3;
            // 
            // textph
            // 
            this.textph.Location = new System.Drawing.Point(522, 31);
            this.textph.Name = "textph";
            this.textph.Size = new System.Drawing.Size(215, 29);
            this.textph.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.record);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(21, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 180);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Search Through User Name  And User Type";
            // 
            // record
            // 
            this.record.BackColor = System.Drawing.SystemColors.GrayText;
            this.record.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.record.Location = new System.Drawing.Point(590, 127);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(111, 29);
            this.record.TabIndex = 7;
            this.record.Text = "Show record";
            this.record.UseVisualStyleBackColor = false;
            this.record.Click += new System.EventHandler(this.record_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phnumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userAccountBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(0, 548);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(789, 44);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userAccountBindingSource
            // 
            this.userAccountBindingSource.DataMember = "User_Account";
            this.userAccountBindingSource.DataSource = this.shopDataSet;
            // 
            // user_AccountTableAdapter
            // 
            this.user_AccountTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "User_Type";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "User_Type";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phnumDataGridViewTextBoxColumn
            // 
            this.phnumDataGridViewTextBoxColumn.DataPropertyName = "ph_num";
            this.phnumDataGridViewTextBoxColumn.HeaderText = "ph_num";
            this.phnumDataGridViewTextBoxColumn.Name = "phnumDataGridViewTextBoxColumn";
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 592);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "UserAccount";
            this.Text = "UserAccount";
            this.Load += new System.EventHandler(this.UserAccount_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button record;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource userAccountBindingSource;
        private shopDataSetTableAdapters.User_AccountTableAdapter user_AccountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phnumDataGridViewTextBoxColumn;
    }
}