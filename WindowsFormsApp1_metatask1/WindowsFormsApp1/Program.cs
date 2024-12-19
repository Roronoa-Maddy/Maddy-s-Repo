using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            // Specify the path where you want to create the folder
            string folderPath = @"C:\TrumpMetamation";

            // Ensure the folder does not already exist
            if (!System.IO.Directory.Exists(folderPath))
            {
                // Open File Explorer to the specified drive
                System.Diagnostics.Process.Start("explorer.exe", @"C:\");
                System.Threading.Thread.Sleep(10000); // Wait for File Explorer to open

                SendKeys.SendWait("^+n");
                // Type the new folder name and press Enter
                SendKeys.SendWait("TrumpMetamation");
                SendKeys.SendWait("{ENTER}");
            }
            else
            {
                Console.WriteLine("Folder already exists.");
            }
            Thread.Sleep(TimeSpan.FromSeconds(10));

            //string filePath = @"D:\TrumpMetamation\MyNewTextFile.txt";
            string filePath = Path.Combine(folderPath, "Welcome.txt");


            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("Welcome to Trump Metamation!");

            }
            

            string[] fileContent = File.ReadAllLines(filePath);
            string[] expectedContent = new string[]
            {
                "Welcome to Trump Metamation!",

            };

            bool contenantmatch = fileContent.Length == expectedContent.Length;
            for (int i = 0; i < fileContent.Length && contenantmatch; i++)
            {
                if (fileContent[i] != expectedContent[i])
                {
                    contenantmatch = false;
                }
            }

            if (contenantmatch)
            {
                Console.WriteLine("The file content is correct.");
            }
            else
            {
                Console.WriteLine("The file content is incorrect.");
            }
            File.Delete(filePath);
            if(!File.Exists(filePath))
            {
                Console.WriteLine("File got deleted");
            }
            Directory.Delete(folderPath);
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Folder Got Deleted");
            }
        }

    }
}
