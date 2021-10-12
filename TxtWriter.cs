using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace TestDocker
{
   public class TxtWriter
    {


        public TxtWriter()
        {

        }

        public TxtWriter(string fileName, int iteration)
        {

            FileName = fileName;
            Iteration = iteration;

        }


        private string _fileName;

        public string FileName { get { return _fileName; } set { _fileName = value; } }

        private int _iteration = 2;

        public int Iteration { get { return _iteration; } set { _iteration = value; } }


        public void Writer()
        {
            string format = "Mddyyyyhhmmsstt";
            string path  = Directory.GetCurrentDirectory();
            if (FileName != null)
                path = path + @"\" + FileName;
            else
                path = path + @"\default-" + DateTime.UtcNow.ToString(format) + ".txt";
            string text = "Привет мир!\nПока мир...";
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    int i = 0;
                    while (i < Iteration)
                    {
                        sw.WriteLine(text);
                        Thread.Sleep(10000);
                        i++;
                    }
                }  
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


    }
}
