using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"c:\temp\New_File.txt";
            //создает файл и записывает туда строку
            File.WriteAllText(file, "1");
            //открывает файл и добавляет туда строку
            File.AppendAllText(file, "2");
            //удаляет файл
            File.Delete(file);

            FileStream file1 = new FileStream(file, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(file1))
            {
                Console.WriteLine("Введите текст, который запишется в файл");
                string text = Console.ReadLine();
                writer.WriteLine(text);
                writer.Close();
            }
            FileStream file2 = new FileStream(file, FileMode.Open);
            using (StreamReader reader = new StreamReader(file2))
            {
                Console.WriteLine("Выведенный текст из файла");
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();
            }
            Console.ReadKey();
        }
    }
}
