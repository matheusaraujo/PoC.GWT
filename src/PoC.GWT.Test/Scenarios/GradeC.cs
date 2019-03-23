using PoC.GWT.Domain;
using PoC.GWT.Test.GiveWhenThen;
using System;
using Xunit;

namespace PoC.GWT.Test.Scenarios
{
    public class GradeC : GiveWhenThen<Student, Result>
    {
        public override void Give(Action<Student> give)
        {
            Input = new Student
            {
                Id = Guid.NewGuid(),
                Name = "Student Grade C",
                Score = 77,
                Presence = 1
            };

            give.Invoke(Input);
        }

        public override void When(Action when)
        {
            when.Invoke();
        }

        public override void Then(Func<Guid, Result> then)
        {
            var result = then.Invoke(Input.Id);
            Assert.NotNull(result);

            Assert.Equal(Input.Id, result.StudentId);
            Assert.Equal(EnumFinalResult.Approved, result.FinalResult);
            Assert.Equal(EnumGrade.C, result.Grade);
            Assert.Equal(77, result.FinalScore);
        }
    }
}