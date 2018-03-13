using System;
using System.Collections.Generic;
using System.IO;
namespace TeleprompterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = file.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}
