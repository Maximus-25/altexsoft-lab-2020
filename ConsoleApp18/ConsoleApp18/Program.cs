using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ConsoleApp18
{
    class Program
    {
        
static void Main(string[] args)
        {
            
            FileManager fm = new FileManager();        
            for (; ; )
            {
                Console.WriteLine("1-FirstMethod.2-SecondMethod.3-ThirdMethod.4-FourthMethod.5-End.");
                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "1":
                        fm.CopyFile();                       
                        FileManager.DeleteChar();
                        break;
                    case "2":
                       FileManager.Method2();
                        break;
                    case "3":
                        FileManager.Sentence();
                        break;
                    case "4":
                        
                        break;
                    
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
                if (temp == "5")
                {
                    break;
                }
            }


        }
    }
}

             



 

    

