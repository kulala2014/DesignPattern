using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    abstract class Phone
    {
        public abstract void Print();
    }

    class ApplePhone : Phone
    {
        public override void Print()
        {
            Console.WriteLine("instance for phone：iPhone");
        }
    }
}
