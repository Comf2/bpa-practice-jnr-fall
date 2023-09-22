using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bpa_practice
{
    internal class GetRelPath
    {
        // Starts from /bin/Debug
        public string GetFullPath(string relPath)
        {
            string currentDir = Environment.CurrentDirectory;
            string fullPath = currentDir + relPath;
            Debug.WriteLine(fullPath);
            return fullPath;
        }
        // In a real scenerio, seperate into methods
        public void GetAllFiles()
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
        public void GoBackForFiles()
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
        public void LogAllTextFiles()
        {
            //Must be two backslashes
            string relPath = "\\assets\\text";
            string fullPath = GetFullPath(relPath);
            var txtFiles = Directory.GetFiles(fullPath, "*.txt");
            foreach (var file in txtFiles)
            {
                //Gets all text in it as a string
                Debug.WriteLine(File.ReadAllText(file));

                // Gets file name, cuts the rest of the path
                Debug.WriteLine(Path.GetFileName(file));

            }
        }
    }
}
