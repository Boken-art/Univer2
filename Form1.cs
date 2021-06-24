using System;
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
            //Student new_student = new Student(textBoxName.Text, textBoxSur.Text, textBoxPasword.Text, checkBoxLabel.Value, curr_date);
            //richTextBox1.AppendText(new_student.Name + " " + new_student.Sur + " " + new_student.Year + "/" + new_student.Month + "/" + new_student.Day + Environment.NewLine);

            var querry = "INSERT INTO Student(id,name,surename,birthdate,password,studentid) VALUES (NULL, textBoxName.Text, textBoxSur.Text,textBoxBirth.Text,textBoxPasword.Text)";
            using (SqlConnection conn = new SqlConnection(_settings.shoolConnString))
            {   // Возьми коннект, добавь в него  {querry} и отправь
                conn.Open();

            }

        }
        // : current Date - year ->  public string reg_year;
        // public string label;   -- checkBoxLabel //
        //public int userid;



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
            surename.Hide();
        }

        private void textBoxPasword_TextChanged(object sender, EventArgs e)
        {
            pass.Hide();
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            label4.Hide();
        }

        private void textBoxMonth_TextChanged(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void textBoxDay_TextChanged(object sender, EventArgs e)
        {
            label6.Hide();
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
    }
}
