using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace داله_تاخذ_المتوسط_الحسابي__الارقام_في_القائمه
{
    class Program
    {
        static void Main()
        { 
        List<int> numb =new List<int > {1,3,9,4,6,7,8};// 5.42857
        calcu_Average(numb);
        
        }
        //بستخدام داله Avreage نحصل على التوسط الحسابي  
        static void calcu_Average(List<int> numb) 

            {
            double average = numb.Average();
                Console.WriteLine("المتوسط الحسابي :"+average);
            }

        
    }
}
