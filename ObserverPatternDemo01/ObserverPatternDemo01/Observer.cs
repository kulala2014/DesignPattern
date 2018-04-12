using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo01
{
    abstract class Observer
    {
        protected string name;
        protected ISubject sub;

        public Observer(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public abstract void Update();
    }

    class StockObserver : Observer
    {
        public StockObserver(string name, ISubject sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} close stock observer, continue working~", sub.SubjectState, name);
        }
    }

    class NBAObserver : Observer
    {
        public NBAObserver(string name, ISubject sub): base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} close stock observer, continue working~", sub.SubjectState, name);
        }
    }
}
