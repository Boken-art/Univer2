using System;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
//using System.IO.File;

namespace Shool2
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private Settings _settings { get => settings; set => settings = value; }
        private Settings settings;
        private readonly Random _random = new Random();  
        private string label = "user";
        
        private int min = 10000;
        private int max = 20000;
        public Form1()
        {
            InitializeComponent();

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.databaseDataSet.Student);
            this.BackColor = Color.FromArgb(41, 44, 51);
        }

        //TODO расписать все составляющие в программировании : переменная, объект, действие etc
        // var, int (числовые знаечения), string, byte - типы данных или типы создаваемых переменных

        private void sendText(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(41, 44, 51);
          
//TODO random id a
            
             
        
            int userid = _random.Next(min, max);  

            User user = new User(textBoxName.Text, textBoxSur.Text, textBoxPassword.Text, userid , label );
            richTextBox1.AppendText(user.name + Environment.NewLine);

            
           // string path = @"C:\Users\rothm\Desktop\output\" + user.name +".txt";
           string path = @"C:\Users\hioli\OneDrive\Рабочий стол\output\" + user.name +".txt";
           
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(userid +"/");
                    sw.Write(user.name + "/");
                    sw.Write(label+ "/");
                    sw.WriteLine(user.pasword);
                    
                }	
            }
            //todo stahnou VS 2022, udelej 4 pole pro vypis uzivatele 
            // Open the file to read from.
           
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            label = "Student";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             label = "Teacher";
        }

        private void materialButton1_Click(object sender, EventArgs e) //LOGIN
        {
            string pathLocal = @"C:\Users\hioli\OneDrive\Рабочий стол\output\"+ materialTextBox1.Text+".txt";
            string fileData = File.ReadAllText(pathLocal);
            
            using (StreamReader sr = File.OpenText(pathLocal))
            {
                string s = "";
                int counter = 1;
                while ((s = sr.ReadLine()) != null)
                {

                    string[] items = s.Split('/');
                    var user_password = items[3];
                    var user_type = items[2];

                    string actual_password = loginPasswordBox.Text;
                    if (user_password != actual_password)
                    {
                        Console.WriteLine("Error");
                        Exit();
                    }


                }
            }
        }

        private void materialButton1_CreateWork(object sender, EventArgs e)
        {

            if (user_type == "student")
            {
                //create work Append (добавляем строку)
            }
            //TODO
        }

            private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void materialTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
        private void materialCard3_Paint(object sender, EventArgs e)
        {
            
        }

      
    }
}
