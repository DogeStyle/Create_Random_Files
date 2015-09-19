using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CreateRandomFIles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("File count = ");
            int count;
            Int32.TryParse(Console.ReadLine(), out count);
            Random rng = new Random();
            string[] ext = { ".jpg", ".docx", ".txt", ".mp3", ".xls" };
            for (int i = 0; i < count; i++)
            {
                byte[] data = new byte[rng.Next(1, 10) * 1024 * 1024];
                rng.NextBytes(data);
                File.WriteAllBytes(i.ToString() + ext[rng.Next(0, ext.Length - 1)], data);
            }
        }
    }
}
