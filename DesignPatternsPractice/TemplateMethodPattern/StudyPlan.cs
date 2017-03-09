using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.TemplateMethodPattern
{
    class StudyPlan
    {
        public List<AbstractStudyStrategy> studyStrategies;
        public StudyPlan()
        {
            studyStrategies = new List<AbstractStudyStrategy>();
        }

        public void AddSubject(AbstractStudyStrategy subject)
        {
            studyStrategies.Add(subject);
        }

        public void RemoveSubject()
        {
            throw new NotImplementedException();
        }

        public void ShowSubjectStrategies()
        {
            studyStrategies.ForEach(s => { s.StudyStrategy(); s.Summary(); });
        }
    }
}
