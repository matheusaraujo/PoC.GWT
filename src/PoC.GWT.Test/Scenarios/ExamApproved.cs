using PoC.GWT.Domain;
using PoC.GWT.Test.GiveWhenThen;

namespace PoC.GWT.Test.Scenarios
{
    public class ExamApproved : GiveWhenThenStudentResult
    {
        protected override string Name => $"Student Exam Approved";
        protected override double Score => 50;
        protected override double? ExamScore => 72;
        protected override double FinalScore => 60;
        protected override double Presence => 0.8;
        protected override EnumFinalResult FinalResult => EnumFinalResult.Approved;
        protected override EnumGrade Grade => EnumGrade.D;
    }
}