namespace Shool2
{
    partial class Form1
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
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.surename = new System.Windows.Forms.Label();
            this.textBoxSur = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Shool2.DatabaseDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.studentTableAdapter = new Shool2.DatabaseDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new Shool2.DatabaseDataSetTableAdapters.TableAdapterManager();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.databaseDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.White;
            nameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            nameLabel.Location = new System.Drawing.Point(114, 198);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(63, 13);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Enter Name";
            nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shool2.Properties.Resources.Avatar;
            this.pictureBox1.Location = new System.Drawing.Point(30, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 559);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(nameLabel);
            this.panel2.Controls.Add(this.surename);
            this.panel2.Controls.Add(this.textBoxSur);
            this.panel2.Controls.Add(this.pass);
            this.panel2.Controls.Add(this.textBoxPasword);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 535);
            this.panel2.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Location = new System.Drawing.Point(72, 439);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Teacher";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton1.Location = new System.Drawing.Point(72, 409);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Student";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // surename
            // 
            this.surename.AutoSize = true;
            this.surename.BackColor = System.Drawing.Color.White;
            this.surename.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.surename.Location = new System.Drawing.Point(93, 225);
            this.surename.Name = "surename";
            this.surename.Size = new System.Drawing.Size(83, 13);
            this.surename.TabIndex = 17;
            this.surename.Text = "Enter Surename";
            this.surename.Click += new System.EventHandler(this.surename_Click);
            // 
            // textBoxSur
            // 
            this.textBoxSur.Location = new System.Drawing.Point(191, 225);
            this.textBoxSur.Name = "textBoxSur";
            this.textBoxSur.Size = new System.Drawing.Size(139, 20);
            this.textBoxSur.TabIndex = 16;
            this.textBoxSur.Click += new System.EventHandler(this.textBoxSur_TextChanged);
            this.textBoxSur.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.White;
            this.pass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pass.Location = new System.Drawing.Point(96, 343);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(81, 13);
            this.pass.TabIndex = 9;
            this.pass.Text = "Enter Password";
            this.pass.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Location = new System.Drawing.Point(191, 341);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.Size = new System.Drawing.Size(139, 20);
            this.textBoxPasword.TabIndex = 3;
            this.textBoxPasword.Click += new System.EventHandler(this.textBoxPasword_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(191, 196);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(139, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.Click += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.Namespace = "http://tempuri.org/DatabaseDataSet.xsd";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))), ((int) (((byte) (192)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(393, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 492);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(338, 405);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(499, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.sendText);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = Shool2.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.databaseDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton radioButton2;

        private System.Windows.Forms.RadioButton radioButton1;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSur;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label surename;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button2;
    }
}

