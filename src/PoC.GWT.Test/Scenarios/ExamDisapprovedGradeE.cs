using PoC.GWT.Domain;
using PoC.GWT.Test.GiveWhenThen;

namespace PoC.GWT.Test.Scenarios
{
    public class ExamDisapprovedGradeE : GiveWhenThenStudentResult
    {
        protected override string Name => $"Student Exam Disapproved Grade E";
        protected override double Score => 50;
        protected override double? ExamScore => 50;
        protected override double FinalScore => 50;
        protected override double Presence => 0.8;
        protected override EnumFinalResult FinalResult => EnumFinalResult.Disapproved;
        protected override EnumGrade Grade => EnumGrade.E;
    }
}