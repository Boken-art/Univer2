using System;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;

namespace Shool2
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        #region Variables
        private Settings _settings { get => settings; set => settings = value; }
        private Settings settings;
        private readonly Random _random = new Random();
        private string Label = "";
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Label = "Teacher";
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Label = "Student";
        }

        private void sendText(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(41, 44, 51);

            int userid = _random.Next(min, max);

            User user = new User(textBoxName.Text, textBoxSur.Text, textBoxPassword.Text, userid  , Label);
            richTextBox1.AppendText(user.name + Environment.NewLine);
            _ = CreateUserFile(user);
            

            // string path = @"C:\Users\rothm\Desktop\output\" + user.name +".txt";
            string path = @"C:\Users\hioli\OneDrive\Рабочий стол\output\" + user.name + ".txt";
            
        }
//todo make login read json 
        private async Task CreateUserFile (User user) //сохранять того юзверя, которого создаем через форму
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true
            };

            var filename = user.userid;
            using (FileStream fs = new FileStream(filename + ".json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<User>(fs, user, options);
                Console.WriteLine("Data has been saved to file");
            
            }

        }


        private void Login_Click(object sender, EventArgs e)
        {

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


        private async Task materialButton1_Click(object sender, EventArgs e) 
        {
                    
            try
            {

                using (FileStream fs = new FileStream(textBoxName.Text + ".json", FileMode.OpenOrCreate))
                {
                     User loginData = await JsonSerializer.DeserializeAsync<User>(fs);
                
                    
                    //Check password correct
                    if (loginData.password != materialTextBox2.Text)
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

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

