using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new ApplePhone();

            Decorator iPhoneWithSticker = new Sticker(phone);

            iPhoneWithSticker.Print();
            Console.WriteLine("*************************************\n");


            Decorator iPhoneWithAccessories = new Accessories(phone);
            iPhoneWithAccessories.Print();

            Console.WriteLine("*************************************\n");

            Sticker sticker = new Sticker(phone);
            Accessories iPhoneAccessories = new Accessories(sticker);
            iPhoneAccessories.Print();
            Console.ReadLine();

        }
    }
}
