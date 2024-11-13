using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace طلب_من_المستخدم_معلومات
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ادخل اسمك :");
            string name = Console.ReadLine();

            Console.WriteLine("ادخل المستوى الخاص بك :");
            string level = Console.ReadLine();

            Console.WriteLine("ادخل المجموعه الخاصه بك :");
            string group = Console.ReadLine();

            Console.WriteLine("مرحباّ بك عزيزتي الحلوه  :"+name);
            Console.WriteLine("انت في المستوى :"+level);
            Console.WriteLine("في المجموعه :"+group);

            Console.ReadKey();

        }
    }
}
