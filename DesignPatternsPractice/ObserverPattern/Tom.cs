using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.ObserverPattern
{
    class Tom : ISubscriber
    {
        public Tom(IPublisher publisher)
        {
            publisher.AddSubscriber(this); 
        }

        public string AccountStatement(string statement)
        {
            Console.WriteLine($"Tom needs to pay {statement}.");
            return statement;
        }

        public string ReadNews(string news)
        {
            Console.WriteLine($"Hi Tom, today's news {news}.");
            return news;
        }
    }
}
