using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.ObserverPattern
{
    class Allen : ISubscriber
    {
        public Allen(IPublisher publisher)
        {
            publisher.AddSubscriber(this);
        }

        public string AccountStatement(string statement)
        {
            Console.WriteLine($"Allen needs to pay {statement}.");
            return statement;
        }

        public string ReadNews(string news)
        {
            Console.WriteLine($"Hi Allen, today's news: {news}.");
            return news;
        }
    }
}
