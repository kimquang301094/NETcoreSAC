using System;
using System.Text;

namespace NETcoreSAC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int age = 1994;
            Console.Write("Nhập năm sinh (đầy đủ 4 số): ");
            
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tuổi hiện tại là " + (Convert.ToInt32(DateTime.Now.ToString("yyyy"))-age) + " .");
        }
    }
}j
