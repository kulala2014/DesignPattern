using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo01
{
    class Boss : ISubject
    {
        private List<Observer> observers = new List<Observer>();
        private string action;
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            observers.ForEach(x=>x.Update());
        }

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }
}
