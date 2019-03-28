using System;
using PoC.GWT.Domain;
using Xunit;

namespace PoC.GWT.Test.GiveWhenThen
{
    public abstract class GiveWhenThenStudentResult : GiveWhenThen<Student, Result>
    {

        public GiveWhenThenStudentResult()
        {
            Id = Guid.NewGuid();
        }

        protected Guid Id { get; set; }

        protected abstract string Name { get; }

        protected abstract double Score { get; }

        protected abstract double? ExamScore { get; }

        protected abstract double FinalScore { get; }

        protected abstract double Presence { get; }

        protected abstract EnumFinalResult FinalResult { get; }

        protected abstract EnumGrade Grade { get; }

        public override void Give(Action<Student> give)
        {
            Input = new Student
            {
                Id = Id,
                Name = Name,
                Score = Score,
                ExamScore = ExamScore,
                Presence = Presence
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

            Assert.Equal(Id, result.StudentId);
            Assert.Equal(FinalResult, result.FinalResult);
            Assert.Equal(Grade, result.Grade);
            Assert.Equal(FinalScore, result.FinalScore);
        }
    }
}
