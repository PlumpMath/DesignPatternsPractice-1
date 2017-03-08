using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsPractice.ObserverPattern;

namespace DesignPatternsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Observer Pattern 
             */
            var publisher = new NytimesNews();

            publisher.PublishNews("Wei is starting to dive into design pattern stuff.");
            publisher.SendStatements("This month is $5 for 30 issues.");

            Console.WriteLine("Hello Nanchang!");
            Console.ReadKey();
        }
    }
}
