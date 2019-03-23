using System;
using System.Collections.Generic;
using System.Linq;
using PoC.GWT.Domain;
using PoC.GWT.Test.Scenarios;
using Xunit;

namespace PoC.GWT.Test.ComposedScenarios
{
    public class AllScenarios : ComposedGiveWhenThen<GiveWhenThen<Student, Result>, Student, Result>
    {
        public AllScenarios()
        {
            Scenarios = new List<GiveWhenThen<Student, Result>>
            {
                new GradeA(),
                new GradeB(),
                new GradeC(),
                new GradeD(),
                new ExamApproved(),
                new ExamDisapprovedGradeE(),
                new ExamDisapprovedGradeF(),
                new GradeF(),
                new InsufficientPresence()
            };
        }

        public override void Give(Action<Student> give)
        {
            foreach (var scenario in Scenarios)
                scenario.Give(give);
        }

        public override void When(Action when)
        {
            when.Invoke();
        }

        public override void Then(Func<IList<Result>> then)
        {
            var results = then.Invoke();
            Assert.Equal(9, results.Count);
            for (var i = 0; i < Scenarios.Count; i++)
            {
                Scenarios[i].Then(guid => results.FirstOrDefault(r => r.StudentId == guid));
                Assert.Equal(Scenarios[i].Input.Id, results[i].StudentId);
            }
        }
    }
}