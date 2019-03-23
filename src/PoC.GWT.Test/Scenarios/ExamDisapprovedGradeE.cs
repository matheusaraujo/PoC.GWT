using System;
using PoC.GWT.Domain;
using Xunit;

namespace PoC.GWT.Test.Scenarios
{
    public class ExamDisapprovedGradeE : GiveWhenThen<Student, Result>
    {
        public override void Give(Action<Student> give)
        {
            Input = new Student
            {
                Id = Guid.NewGuid(),
                Name = "Student Exam Disapproved Grade E",
                Score = 50,
                ExamScore = 50,
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
            Assert.Equal(EnumGrade.E, result.Grade);
            Assert.Equal(50, result.FinalScore);
        }
    }
}