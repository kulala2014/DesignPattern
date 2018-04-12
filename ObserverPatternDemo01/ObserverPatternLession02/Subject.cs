using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternLession02
{
   interface Subject
    {
        void Notify();
        string SubjectState
        { get; set; }
    }

    delegate void EventHandler();

    class Boss : Subject
    {
        public event EventHandler Update;

        private string action;

        public void Notify()
        {
            Update();
        }

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }

    }

    class Secretary : Subject
    {
        public event EventHandler Update;

        private string action;

        public void Notify()
        {
            Update();
        }

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }

    }
}
