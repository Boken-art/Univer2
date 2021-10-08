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
            this.BackColor = Color.FromArgb(41, 44, 51);
        }

      

        private void sendText(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(41, 44, 51);
          

            
             
        
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

        private void radioButton2_CheckedChange (object sender, EventArgs e)
        {
             label = "Teacher";
        }

        private void materialButton1_Click(object sender, EventArgs e) //LOGIN
        {
            //Check login
            string pathLocal = @"C:\Users\hioli\OneDrive\Рабочий стол\output\" + materialTextBox1.Text+ ".txt";

            try 
            {
                File.ReadAllText(pathLocal);
                var user_password = "";
                using (StreamReader sr = File.OpenText(pathLocal))
                {

                    string s = "";
                    //Check user file not empty
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] items = s.Split('/');
                        user_password = items[3];
                        var user_type = items[2];
                    }

                    //Check password correct
                    if (user_password != materialTextBox2.Text)
                    {
                        richTextBox1.AppendText("Password error  \n");
                    }
                }
                richTextBox1.AppendText("Login successful \n"); //После всех действий - сообщение ОК
            }catch (Exception ex )
            {
                richTextBox1.AppendText("Login error \n"); //Если логин не совпал  - сообщение Не ОК
            }


        }

        private void materialButton1_CreateWork(object sender, EventArgs e)
        {

            /*if (user_type == "student")
            {
                //create work Append (добавляем строку)
            }
            //TODO
            */
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string pathFile = @"C:\Users\hioli\OneDrive\Рабочий стол\output\dragDrop\";
            string[] fileGet = (string[])e.Data.GetData(DataFormats.FileDrop);
            string fileNewplace = fileGet[0];
            File.Create(fileNewplace);
            

            /* if (File.Exists(pathFile))
             {
                 File.Copy(F, pathFile);
             }*/


            //string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
           // if (files == null || files.Length == 0) return;
              //  textBox1.Text = files.First(); 

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string path = @"C:\Users\hioli\OneDrive\Рабочий стол\output" + materialTextBox1.Text + ".txt";

            try
            {
                File.ReadAllText(path);
                using (StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        if (string.Compare("work;", sr.ReadLine()))
                        {
                            //вытащить абзац и выписать его в техт бох
                        }
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            } 
        }
    }
}

                 [              LEVEL 1       OPEN FILE (С ЧЕМ РАБОТАЕМ)                            ]
                     [          LEVEL 2       READ FILE (СЧИТЫВАЕМ ТО С ЧЕМ РАБОТАЕМ)      ]
                          [     LEVEL 3       ВСЕ ЧТО УГОДНО                     ] 