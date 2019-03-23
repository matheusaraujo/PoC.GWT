using PoC.GWT.Domain;
using PoC.GWT.Test.GiveWhenThen;
using System;
using Xunit;


namespace PoC.GWT.Test.Scenarios
{
    public class ExamDisapprovedGradeF : GiveWhenThen<Student, Result>
    {
        public override void Give(Action<Student> give)
        {
            Input = new Student
            {
                Id = Guid.NewGuid(),
                Name = "Student Exam Disapproved Grade F",
                Score = 42,
                ExamScore = 30,
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
            Assert.Equal(36, result.FinalScore);
        }
    }
}