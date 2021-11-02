using System;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
//using System.IO.File;
using System.Text;

namespace Shool2
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        #region Variables
        private Settings _settings { get => settings; set => settings = value; }
        private Settings settings;
        private readonly Random _random = new Random();
        private string label = "user";
        private string logPath = @"C:\Users\hioli\OneDrive\Рабочий стол\output\";
        private StringBuilder logger = new StringBuilder();
        //private string pathFile = @"C:\Users\hioli\OneDrive\Рабочий стол\output\dragDrop\";
        private int min = 10000;
        private int max = 20000;
        #endregion

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

            User user = new User(textBoxName.Text, textBoxSur.Text, textBoxPassword.Text, userid, label);
            richTextBox1.AppendText(user.name + Environment.NewLine);


            // string path = @"C:\Users\rothm\Desktop\output\" + user.name +".txt";
            string path = @"C:\Users\hioli\OneDrive\Рабочий стол\output\" + user.name + ".txt";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(userid + "/");
                    sw.Write(user.name + "/");
                    sw.Write(label + "/");
                    sw.WriteLine(user.pasword);

                }
            }


        }

        #region Elements
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

        private void radioButton2_CheckedChange(object sender, EventArgs e)
        {
            label = "Teacher";
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
        #endregion


        private void materialButton1_Click(object sender, EventArgs e) //LOGIN
        {
            //Check login
            string pathLocal = @"C:\Users\hioli\OneDrive\Рабочий стол\output\" + materialTextBox1.Text + ".txt";

            try
            {
                File.ReadAllText(pathLocal);
                var user_password = string.Empty;
                using (StreamReader sr = File.OpenText(pathLocal))
                {

                    string s = string.Empty;
                    //Check user file not empty
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] items = s.Split('/');
                        string elem = items[3];    // TODO looger разобраться
                        user_password = elem;
                        var user_type = items[2];
                    }

                    //Check password correct
                    if (user_password != materialTextBox2.Text)
                    {
                        richTextBox1.AppendText("Password error  \n");
                    }
                }
                richTextBox1.AppendText("Login successful \n"); //После всех действий - сообщение ОК
            } 
            catch (Exception ex)
            {
                logger.Append(ex);
                File.AppendAllText(logPath + "log.txt", logger.ToString());  //out of bounds : 210
                richTextBox1.AppendText("See log file \n");
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


        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            string pathLocal = @"C:\Users\rothm\Desktop\output\" + materialTextBox1.Text + ".txt";
            richTextBox2.AppendText("Данные скопированы!");

            if(File.Exists(pathLocal))
            {
                using(StreamWriter sw = File.AppendText(pathLocal))
                {
                    sw.WriteLine("work8;");
                    sw.WriteLine("текст из файла");
                    sw.WriteLine("end;");
                }
            }


            // Login -> D&D файла -> Считываем и добавляек к файлу юзера
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            //TODO Debug drop text
            string pathFile = @"C:\Users\hioli\OneDrive\Рабочий стол\output\dragDrop\";
            string[] fileGet = (string[])e.Data.GetData(DataFormats.FileDrop);
            string fileNewplace = fileGet[0];
            string line = string.Empty;
            File.Create(fileNewplace);

            e.Effect = DragDropEffects.All;
            StringBuilder text = new StringBuilder();

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                try
                {
                    File.ReadAllText(files[0]);
                    using (StreamReader sr = File.OpenText(files[0]))
                    {
                        while (!sr.EndOfStream)
                        {
                            if (string.Compare("work;", sr.ReadLine()) == 0)
                            {
                                while (sr.Peek() >= 0)
                                {   //TODO выбрать номер работы

                                    text.Append(line = sr.ReadLine());

                                    if (string.Compare("end;", line) == 0)
                                    {
                                        break;
                                    }

                                }
                            }
                        }
                        richTextBox2.AppendText(text.ToString());
                    }
                }
                catch (Exception ex)
                {
                    logger.Append(ex);
                    File.AppendAllText(logPath + "log.txt", logger.ToString());
                    Console.WriteLine(ex);
                }



            }

            #region Comments
            /*using (OpenFileDialog dialog = new OpenFileDialog())  
            {  
                if (dialog.ShowDialog() == DialogResult.OK)  
                {  
                    panel1.Text = dialog.FileName;
                    //richTextBox2.AppendText(blabla);
                }  
            }  */



            /* if (File.Exists(pathFile))
             {
                 File.Copy(F, pathFile);
             }*/
            //string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            // if (files == null || files.Length == 0) return;
            //  textBox1.Text = files.First(); 
            #endregion
        }

            private void button2_Click_1(object sender, EventArgs e)
            {
                string path = @"C:\Users\hioli\OneDrive\Рабочий стол\output\" + materialTextBox1.Text + ".txt";
                StringBuilder text = new StringBuilder();
                string loosePart = "";
                string line = "";
            
                
                try 
                {
                    File.ReadAllText(path);
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            if (string.Compare("work;", sr.ReadLine()) == 0)
                            {
                                while (sr.Peek() >= 0 ) 
                                {   //TODO выбрать номер работы

                                    text.Append(line = sr.ReadLine());                                                                    

                                if (string.Compare("end;", line) == 0)
                                    {
                                        break;
                                    }

                                }

                            }
                        }
                        richTextBox2.AppendText(text.ToString());
                    }
                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex);   //TODO сохранять логи ошибок в файл
                }
            }

        
    }
}

