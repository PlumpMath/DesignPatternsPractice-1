using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsPractice.ObserverPattern;
using DesignPatternsPractice.TemplateMethodPattern;

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

            /*
             * Template Method Pattern
             */
            var studyPlan = new StudyPlan();
            studyPlan.AddSubject(new StudyEnglish());
            studyPlan.AddSubject(new StudyProgramming());
            studyPlan.ShowSubjectStrategies();

            Console.WriteLine("Hello Nanchang!");
            Console.ReadKey();
        }
    }
}
