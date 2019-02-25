using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Observable
{
    public class Observable
    {
        private List<Observer> observers = new List<Observer>();

        public void Subscribe(Observer o)
        {
            observers.Add(o);
        }

        public void UnSubscribe(Observer o)
        {
            observers.Remove(o);
        }

        public void Notify(string message, bool? status)
        {
            observers.ForEach(x => x.Update(message, status));
        }
    }
}
