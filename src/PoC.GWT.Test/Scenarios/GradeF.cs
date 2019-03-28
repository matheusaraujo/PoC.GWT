using PoC.GWT.Domain;
using PoC.GWT.Test.GiveWhenThen;

namespace PoC.GWT.Test.Scenarios
{
    public class GradeF : GiveWhenThenStudentResult
    {
        protected override string Name => $"Student Grade F";
        protected override double Score => 30;
        protected override double? ExamScore => null;
        protected override double FinalScore => 30;
        protected override double Presence => 0.8;
        protected override EnumFinalResult FinalResult => EnumFinalResult.Disapproved;
        protected override EnumGrade Grade => EnumGrade.F;
    }
}