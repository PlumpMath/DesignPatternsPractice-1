using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.ObserverPattern
{
    interface IPublisher
    {
        void AddSubscriber(ISubscriber subscriber);

        void RemoveSubscriber(ISubscriber subscriber);

        void PublishNews(string news);

        void SendStatements(string statement);
    }
}
