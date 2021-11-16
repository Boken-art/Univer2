using System;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace Shool2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Person tom = new Person( 01001, "Tom");
            //string json = JsonSerializer.Serialize<Person>(tom);
            //Console.WriteLine(json);
            //Person restoredPerson = JsonSerializer.Deserialize<Person>(json);
            //Console.WriteLine(restoredPerson);

           /* using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))    
            {
                Person tom = new Person() { Id = 35, Name = "Tom" };
                await JsonSerializer.SerializeAsync<Person>(fs, tom);
                Console.WriteLine("Data has been saved to file");
            }
             
            // чтение данных
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                Person restoredPerson = await JsonSerializer.DeserializeAsync<Person>(fs);
                Console.WriteLine($"Name: {restoredPerson.Name}  Age: {restoredPerson.Id}");
            }*/
        }
    }
}
