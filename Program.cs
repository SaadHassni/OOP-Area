using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class person
    {
        wristwatch rhand;

        public person(wristwatch obj)
        {
            rhand.dial = obj.dial;
        }
    }

    class wristwatch
    {
        string dial;
    }
    class Program
    {
        static void Main(string[] args)
        {
            wristwatch o = new wristwatch();
            person obj = new person(o);

        }
    }
}
