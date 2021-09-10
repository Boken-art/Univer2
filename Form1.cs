using System;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Shool2
{
    public partial class Form1 : Form
    {
        private Settings _settings { get => settings; set => settings = value; }
        private Settings settings;
        public Form1()
        {
            InitializeComponent();

            textBoxPasword.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.databaseDataSet.Student);
            this.BackColor = Color.FromArgb(41, 44, 51);
        }

        //TODO расписать все составляющие в программировании : переменная, объект, действие etc
        // var, int (числовые знаечения), string, byte - типы данных или типы создаваемых переменных

        private void sendText(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(41, 44, 51);
            //TODO создать поля и чекбокс
            //YearLabel.Text = DateTime.Now.Year.ToString();
            
            // создать студента исходя из нового конструктора (который мы поменяли)


        }


        private void AddWork()
        {
            //Work work1 = new Work(workname, studentid, predmetid, titul)
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            /*name1.Hide();*/

        }

        private void textBoxSur_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void surename_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
