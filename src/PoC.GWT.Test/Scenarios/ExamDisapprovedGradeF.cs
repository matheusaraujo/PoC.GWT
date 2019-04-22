using PoC.GWT.Domain;
using PoC.GWT.Test.GivenWhenThen;

namespace PoC.GWT.Test.Scenarios
{
    public class ExamDisapprovedGradeF : GivenWhenThenStudentResult
    {
        protected override string Name => $"Student Exam Disapproved Grade F";
        protected override double Score => 42;
        protected override double? ExamScore => 30;
        protected override double FinalScore => 36;
        protected override double Presence => 0.8;
        protected override EnumFinalResult FinalResult => EnumFinalResult.Disapproved;
        protected override EnumGrade Grade => EnumGrade.F;
    }
}