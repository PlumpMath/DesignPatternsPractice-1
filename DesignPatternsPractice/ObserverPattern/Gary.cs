using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.ObserverPattern
{
    class Gary : ISubscriber
    {
        public Gary(IPublisher publisher)
        {
            publisher.AddSubscriber(this); 
        }
        public string AccountStatement(string statement)
        {
            Console.WriteLine($"Gary needs to pay {statement}.");
            return statement;
        }

        public string ReadNews(string news)
        {
            Console.WriteLine($"Hi Gary, today's news: {news}.");
            return news;
        }
    }
}
