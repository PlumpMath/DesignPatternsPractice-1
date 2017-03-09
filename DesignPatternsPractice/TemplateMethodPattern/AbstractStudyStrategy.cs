using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.TemplateMethodPattern
{
    abstract class AbstractStudyStrategy
    {
        protected StringBuilder strBuiler;

        public void StudyStrategy()
        {
            FindLearningPurpose();
            FindResource();
            ReadingAndThinking();
            NotesAndReview();
            Practice();
            if (CanTeachHook())
                EnhanceFromTeaching();
        }

        public void Summary()
        {
            Console.WriteLine(strBuiler.ToString());
        }

        public abstract void FindLearningPurpose();

        public abstract void FindResource();

        public abstract void ReadingAndThinking();

        public abstract void NotesAndReview();

        public abstract void Practice();

        public abstract void EnhanceFromTeaching();

        public virtual Boolean CanTeachHook()
        {
            return true;
        }
    }
}
