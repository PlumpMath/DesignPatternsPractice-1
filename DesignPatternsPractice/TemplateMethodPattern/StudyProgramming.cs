using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.TemplateMethodPattern
{
    class StudyProgramming : AbstractStudyStrategy
    {
        public StudyProgramming()
        {
            strBuiler = new StringBuilder();
        }

        public override void EnhanceFromTeaching()
        {
            strBuiler.AppendLine("Enhance From Teaching");
            strBuiler.AppendLine("Study programming will help to establish a new mind set to thinking about world.");
            strBuiler.AppendLine();
        }

        public override void FindLearningPurpose()
        {
            strBuiler.AppendLine("Find Learning Purpose:");
            strBuiler.AppendLine("Study programming will help to establish a new mind set to thinking about world.");
            strBuiler.AppendLine();
        }

        public override void FindResource()
        {
            strBuiler.AppendLine("Find Resource:");
            strBuiler.AppendLine("Study programming will help to establish a new mind set to thinking about world.");
            strBuiler.AppendLine();
        }

        public override void NotesAndReview()
        {
            strBuiler.AppendLine("Notes And Review:");
            strBuiler.AppendLine("Study programming will help to establish a new mind set to thinking about world.");
            strBuiler.AppendLine();
        }

        public override void Practice()
        {
            strBuiler.AppendLine("Practice:");
            strBuiler.AppendLine("Study programming will help to establish a new mind set to thinking about world.");
            strBuiler.AppendLine();
        }

        public override void ReadingAndThinking()
        {
            strBuiler.AppendLine("Reading And Thinking:");
            strBuiler.AppendLine("Study programming will help to establish a new mind set to thinking about world.");
            strBuiler.AppendLine();
        }

        public override bool CanTeachHook()
        {
            return base.CanTeachHook();
        }
    }
}
