using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();

            StockObserver stock01 = new StockObserver("kulala", boss);

            NBAObserver nba01 = new NBAObserver("kobe", boss);

            boss.Attach(stock01);
            boss.Attach(nba01);
            boss.SubjectState = "Boss coming~";

            boss.Notify();
        }                                                                                                                                                           
    }
}
