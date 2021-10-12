using System;

namespace TestDocker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите имя файла");
            var name =  Console.ReadLine();

            Console.WriteLine("Введите колличество итераций");

            string strCount = Console.ReadLine();
            int count = 0;
            if (!String.IsNullOrEmpty(strCount))
            count = Int32.Parse(strCount);

            TxtWriter txtWriter;
            if (!String.IsNullOrEmpty(name) && count != 0)
            {
                txtWriter = new TxtWriter(name, count);
            }
            else
                txtWriter = new TxtWriter();
            txtWriter.Writer();

        }
    }
}
