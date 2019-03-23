using PoC.GWT.Domain;
using PoC.GWT.Test.GiveWhenThen;
using System;
using Xunit;


namespace PoC.GWT.Test.Scenarios
{
    public class InsufficientPresence : GiveWhenThen<Student, Result>
    {
        public override void Give(Action<Student> give)
        {
            Input = new Student
            {
                Id = Guid.NewGuid(),
                Name = "Student Insufficient Presence",
                Score = 80,
                Presence = 0.5
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
            Assert.Equal(0, result.FinalScore);
        }
    }
}