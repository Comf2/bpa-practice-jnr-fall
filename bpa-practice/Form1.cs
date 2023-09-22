using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace bpa_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Must be two backslashes
            string relPath = "\\assets\\text";
            string fullPath = getFullPath(relPath);
            var txtFiles = Directory.GetFiles(fullPath, "*.txt");
            foreach (var file in txtFiles)
            {
                //Gets all text in it as a string
                Debug.WriteLine(File.ReadAllText(file));

                // Gets file name, cuts the rest of the path
                Debug.WriteLine(Path.GetFileName(file));

            }
        }
        // Starts from /bin/Debug
        private string getFullPath(string relPath)
        {
            string currentDir = Environment.CurrentDirectory;
            string fullPath = currentDir + relPath;
            Debug.WriteLine(fullPath);
            return fullPath;
        }
        // In a real scenerio, seperate into methods
        private void getAllFiles()
        {
            // Starts from /bin/Debug
            string currentDir = Environment.CurrentDirectory;
            string relPath = "\\assets\\text";
            string fullPath = currentDir + relPath;
            Debug.WriteLine(fullPath);
            // Can put any extension here if need be
            var txtFiles = Directory.GetFiles(fullPath, "*.txt");
            foreach (var file in txtFiles)
            {
                // Gets all text from files as string
                Debug.WriteLine(File.ReadAllText(file));
                //Gets all file names, cuts the path, keeps extension
                Debug.WriteLine(Path.GetFileName(file));
            }
        }
        private void goBackForFiles()
        {
            string currentDir = Environment.CurrentDirectory;
            string relPath = "\\..\\..\\assets\\text";
            string fullPath = currentDir + relPath;
            Debug.WriteLine(fullPath);
            var txtFiles = Directory.GetFiles(fullPath, "*.txt");
            foreach (var file in txtFiles)
            {
                Debug.WriteLine(File.ReadAllText(file));
            }
        }
    }
}
