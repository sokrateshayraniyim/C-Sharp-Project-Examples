using System;
using System.Globalization;
using System.IO;

namespace NoteTakingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Note");
                Console.WriteLine("2. Exit");

                Console.Write("Make a choice : ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Head: ");
                        string head = Console.ReadLine();

                        Console.Write("Content: ");
                        string content = Console.ReadLine();

                        //string dosyaAdi = Path.Combine("NOTES", head + ".txt");

                        string dosyaAdi = $@"{head}";
                        


                        using (StreamWriter sw = new StreamWriter(dosyaAdi+".txt"))
                        {
                            sw.Write(content);
                        }

                        Console.WriteLine("Saved");
                        break;

                    case "2":
                        Console.WriteLine("Shut down the app");
                        return;

                    default:
                        Console.WriteLine("This is not an option");
                        break;
                }
            }
        }
    }
}