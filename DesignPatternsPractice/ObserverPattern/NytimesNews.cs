using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.ObserverPattern
{
    class NytimesNews : IPublisher
    {
        private List<ISubscriber> _subscriber;

        public NytimesNews()
        {
            _subscriber = new List<ISubscriber>();

            var allen = new Allen(this);
            var gary = new Gary(this);
            var tom = new Tom(this);
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            _subscriber.Add(subscriber);
        }

        public void PublishNews(string news)
        {
            _subscriber.ForEach(s => s.ReadNews(news));
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            _subscriber.Remove(subscriber);
        }

        public void SendStatements(string statement)
        {
            _subscriber.ForEach(s => s.AccountStatement(statement));
        }
    }
}
