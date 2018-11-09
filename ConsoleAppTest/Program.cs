using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {   
            LOX lox = new LOX("1 commit");

            Console.ReadKey();
        }
    }

    class LOX
    {
        public LOX()
        {

        }

        public LOX(string s)
        {
            minilox = s;
        }

        public string minilox;
    }
}
