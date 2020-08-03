using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp18
{
    class FileManager
    {
        private const string DirectoriesPath = "";
        private Dictionary<string, string> Directories;
        private static StringComparison or;

        public FileManager()
        {
            Directories = new Dictionary<string, string>();
        }

        public void ShowDirectories()
        {
            Directories = GetDerictories(DirectoriesPath);


        }

        private Dictionary<string, string> GetDerictories(string directoriesPath)
        {
            var dirs = new Dictionary<string, string>();
            //получить масив названий папок

            //  for (int i = 0; i < length; i++)
            {
                //     dirs.Add(i,);
            }

            //отсортировать

            return dirs;
        }

        public string CopyFile() //1Method
        {
            string path = @"C:\Users\Professional\source\repos\ConsoleApp18\file.1.txt";
            string newPath = @"C:\Users\Professional\source\repos\ConsoleApp18\copy.file.1.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.CopyTo(newPath, true);

            }
            Console.WriteLine(File.ReadAllText(newPath));
            return newPath;


        }
        static public void DeleteChar()
        {
            
                string text = File.ReadAllText(@"C:\Users\Professional\source\repos\ConsoleApp18\copy.file.1.txt");  
                Console.WriteLine("Enter a character or word to delete ");
                string word = Console.ReadLine();
                string[] words = new string[] { word };                
            if (text.Contains(word))
            {
                text = text.Replace(word, "");
                File.WriteAllText(@"C:\Users\Professional\source\repos\ConsoleApp18\copy.file.1.txt", text);
                Console.WriteLine("Deleted");

            }
            else
            {
                Console.WriteLine("No matches entered.");
            }
   
        }

  
        static public string Method2()//2Method;
        {
            string s = "";
            string[] textMass;
            StreamReader sr = new StreamReader(@"C:\Users\Professional\source\repos\ConsoleApp18\copy.file.1.txt");
            
            while (sr.EndOfStream != true)
            {
                s += sr.ReadLine();
            }
            textMass = s.Split(new char[] { ' ', '\n', '\b', '\p' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Number of words:");
            Console.WriteLine(textMass.Length);
            sr.Close();

            Console.WriteLine("Every tenth word:");
            for (int i = 9; i < textMass.Length; i = i + 10)
            {
                Console.Write(textMass[i]);
                Console.Write(", ");
            }
            return s;
        }
        
        static public void Sentence()//3Method
        {
            var s = File.ReadAllText(@"C:\Users\Professional\source\repos\ConsoleApp18\file.1.txt", Encoding.Default).Split('.');
            var k = s[2];
            string ReverseString="";
            string[] words = k.Split(' ');
            Console.WriteLine("Reversed third sentence:");
        
            for (int count = 0; count < words.Length; count++)
            {
                char[] chArray = words[count].ToArray();
                for (int i = 0; i < chArray.Length / 2; i++)
                {
                    char chTemp = chArray[i];
                    chArray[i] = chArray[(chArray.Length - 1) - i];
                    chArray[(chArray.Length - 1) - i] = chTemp;
                }
                ReverseString += new string(chArray) + " ";
            }
            Console.WriteLine(ReverseString);
            Console.ReadKey();
        }
    }
}
