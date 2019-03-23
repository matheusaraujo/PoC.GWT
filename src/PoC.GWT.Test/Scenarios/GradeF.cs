using System;
using PoC.GWT.Domain;
using Xunit;

namespace PoC.GWT.Test.Scenarios
{
    public class GradeF : GiveWhenThen<Student, Result>
    {
        public override void Give(Action<Student> give)
        {
            Input = new Student
            {
                Id = Guid.NewGuid(),
                Name = "Student Grade F",
                Score = 30,
                Presence = 0.8
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
            Assert.Equal(EnumFinalResult.Disapproved, result.FinalResult);
            Assert.Equal(EnumGrade.F, result.Grade);
            Assert.Equal(30, result.FinalScore);
        }
    }
}