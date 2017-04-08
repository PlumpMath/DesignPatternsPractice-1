using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsPractice.ObserverPattern;
using DesignPatternsPractice.TemplateMethodPattern;
using DesignPatternsPractice.StrategyPattern;

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
             * Template Method Pattern(AbstractStudyStrategy class) 
             * Composite Pattern (StudyPlan class)
             */
            var studyPlan = new StudyPlan();
            studyPlan.AddSubject(new StudyEnglish());
            studyPlan.AddSubject(new StudyProgramming());
            studyPlan.ShowSubjectStrategies();

            /*
             * Merge sort in recursive call
             */
            Int32[] arr = new Int32[10] { 9, 22, 0, 1223, 48, 5, 47, 90, 42, 10};
            var sort = new Sort<Int32>(arr, new MergeSort<Int32>());
            foreach(var i in sort.Ascending())
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            foreach(var i in sort.Descending())
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Console.WriteLine("Hello Nanchang!");
            Console.ReadKey();
        }
    }
}
