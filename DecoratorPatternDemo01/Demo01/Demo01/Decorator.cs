using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
     abstract class Decorator : Phone
   {
        private Phone phone;
        public Decorator(Phone p)
        {
            phone = p;
        }

        public override void Print()
        {
            if (phone != null)
            {
                phone.Print();
            }
        }
    }

     class Sticker : Decorator
    {
        public Sticker(Phone p) : base(p)
        {

        }

        public override void Print()
        {
            base.Print();
            AddSticker();
        }

        public void AddSticker()
        {
            Console.WriteLine("Add sticker for phone");
        }
    }

    class Accessories : Decorator
    {
        public Accessories(Phone p) : base(p)
        {

        }

        public override void Print()
        {
            base.Print();
            AddAccessories();
        }

        public void AddAccessories()
        {
            Console.WriteLine("Add accessories for phone");
        }
    }

}
