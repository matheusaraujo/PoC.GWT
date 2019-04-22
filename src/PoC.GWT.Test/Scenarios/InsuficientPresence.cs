using PoC.GWT.Domain;
using PoC.GWT.Test.GivenWhenThen;

namespace PoC.GWT.Test.Scenarios
{
    public class InsufficientPresence : GivenWhenThenStudentResult
    {
        protected override string Name => $"Student Insufficient Presence";
        protected override double Score => 80;
        protected override double? ExamScore => null;
        protected override double FinalScore => 0;
        protected override double Presence => 0.4;
        protected override EnumFinalResult FinalResult => EnumFinalResult.Disapproved;
        protected override EnumGrade Grade => EnumGrade.F;
    }
}