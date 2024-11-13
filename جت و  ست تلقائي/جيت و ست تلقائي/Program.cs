using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace جيت_و_ست_تلقائي
{
    public class cuost
    {
        private string _fristname;

        public string Fristname
        {
            get { return _fristname; }
            set { _fristname = value; }
        }
        private string _lastname;

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }


        public string fullname()
        {

            return _fristname + "" + _lastname;
        
        }


    }



    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }


    }
}
