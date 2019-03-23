using System;
using PoC.GWT.Domain;
using Xunit;

namespace PoC.GWT.Test.Scenarios
{
    public class GradeA : GiveWhenThen<Student, Result>
    {
        public override void Give(Action<Student> give)
        {
            Input = new Student
            {
                Id = Guid.NewGuid(),
                Name = "Student Grade A",
                Score = 95,
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
            Assert.Equal(EnumGrade.A, result.Grade);
            Assert.Equal(95, result.FinalScore);
        }
    }
}