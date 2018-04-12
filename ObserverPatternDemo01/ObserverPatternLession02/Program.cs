using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternLession02
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();

            StockObserver stock01 = new StockObserver("kulala", boss);
            NBAObserver nba01 = new NBAObserver("Kobe", boss);

            boss.Update += new EventHandler(stock01.CloseStockMarket);
            boss.Update += new EventHandler(nba01.CloseNBADirection);

            boss.SubjectState = "I am Boss,I coming";

            boss.Notify();
        }
    }
}
