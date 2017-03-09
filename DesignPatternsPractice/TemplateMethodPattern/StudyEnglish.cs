using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.TemplateMethodPattern
{
    class StudyEnglish : AbstractStudyStrategy
    {
        public StudyEnglish()
        {
            strBuiler = new StringBuilder();
        }

        public override void EnhanceFromTeaching()
        {
            strBuiler.AppendLine("Enhance From Teaching");
            strBuiler.AppendLine("Open a new world to the people whose first language is not English.");
            strBuiler.AppendLine();
        }

        public override void FindLearningPurpose()
        {
            strBuiler.AppendLine("Find Learning Purpose:");
            strBuiler.AppendLine("Open a new world to the people whose first language is not English.");
            strBuiler.AppendLine();
        }

        public override void FindResource()
        {
            strBuiler.AppendLine("Find Resource:");
            strBuiler.AppendLine("Open a new world to the people whose first language is not English.");
            strBuiler.AppendLine();
        }

        public override void NotesAndReview()
        {
            strBuiler.AppendLine("Notes And Review:");
            strBuiler.AppendLine("Open a new world to the people whose first language is not English.");
            strBuiler.AppendLine();
        }

        public override void Practice()
        {
            strBuiler.AppendLine("Practice:");
            strBuiler.AppendLine("Open a new world to the people whose first language is not English.");
            strBuiler.AppendLine();
        }

        public override void ReadingAndThinking()
        {
            strBuiler.AppendLine("Reading And Thinking:");
            strBuiler.AppendLine("Open a new world to the people whose first language is not English.");
            strBuiler.AppendLine();
        }

        public override bool CanTeachHook()
        {
            return false;
        }
    }
}
