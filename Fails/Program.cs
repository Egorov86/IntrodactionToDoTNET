//#define WRITE_TO_FILE
#define READ_FROM_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //пространство имен SysteInputOut
using System.Diagnostics; //пространство имен для чтения файла


namespace Fails
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if WRITE_TO_FILE
            StreamWriter sw = new StreamWriter("File.txt");   // поток чтобы писать в файл
            sw.WriteLine("Hello files");
            sw.Close(); // закрытие потока обязательно
            Process.Start("notepad", "File.txt"); // открытие файла  
#endif
#if READ_FROM_FILE
            StreamReader sr = new StreamReader("File.txt"); // чтение из файла
            while(!sr.EndOfStream)
            {
                string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }
            sr.Close();
#endif
        }
    }
}
