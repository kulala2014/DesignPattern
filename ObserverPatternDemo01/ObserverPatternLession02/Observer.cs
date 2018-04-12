using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternLession02
{
    class StockObserver
    { 
        private string name;
        protected Subject sub;

        public StockObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine("{0} {1} close stock observer, continue working~", sub.SubjectState, name);
        }
    }

    class NBAObserver 
    {
        private string name;
        protected Subject sub;
        public NBAObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseNBADirection()
        {
            Console.WriteLine("{0} {1} close stock observer, continue working~", sub.SubjectState, name);
        }
    }
}
