using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class FileSystem
    {
        public void Reader()
        {
            try
            {

                string filePath = (string)Directory.GetCurrentDirectory() + "\\data.txt";
                using StreamReader streamReader = new(filePath);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Writer()
        {
            try
            {
                string filePath = (string)Directory.GetCurrentDirectory() + "\\write.txt";
                using StreamWriter streamWriter = new(filePath);
                streamWriter.WriteLine("TEST");
                streamWriter.WriteLine("WRITE");
            }
            catch(Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }
    }
}
