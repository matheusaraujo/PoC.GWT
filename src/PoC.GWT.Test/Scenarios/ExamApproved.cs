using PoC.GWT.Domain;
using PoC.GWT.Test.GiveWhenThen;
using System;
using Xunit;

namespace PoC.GWT.Test.Scenarios
{
    public class ExamApproved : GiveWhenThen<Student, Result>
    {
        public override void Give(Action<Student> give)
        {
            Input = new Student
            {
                Id = Guid.NewGuid(),
                Name = "Student Exam Approved",
                Score = 50,
                ExamScore = 72,
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
            Assert.Equal(EnumFinalResult.Approved, result.FinalResult);
            Assert.Equal(EnumGrade.D, result.Grade);
            Assert.Equal(60, result.FinalScore);
        }
    }
}