using System;
using System.IO;
using System.Linq;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main()
        {
           HashSet<LogRecord> list = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using StreamReader sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    string name = line[0];
                    DateTime instant = DateTime.Parse(line[1]);
                    list.Add(new LogRecord { Username = name, Instant = instant });
                }

                Console.WriteLine("Total users: " + list.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}