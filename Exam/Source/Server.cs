using Exam.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public abstract class Server
    {

        //private List<Action<List<Computer>>> _listners = new List<Action<List<Computer>>>();

        //public void Subscribe(Action<List<Computer>> subscriber)
        //{
        //    _listners.Add(subscriber);
        //}
        //protected void Notify(List<Computer> data)
        //{
        //    foreach (var subscriber in _listners)
        //        subscriber(data);
        //}


        private List<Action> _listners = new List<Action>();

        public void Subscribe(Action subscriber)
        {
            _listners.Add(subscriber);
        }
        protected void Notify()
        {
            foreach (var subscriber in _listners)
                subscriber();
        }

    }
}
