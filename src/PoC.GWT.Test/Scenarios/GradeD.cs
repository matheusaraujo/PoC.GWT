using PoC.GWT.Domain;
using PoC.GWT.Test.GiveWhenThen;

namespace PoC.GWT.Test.Scenarios
{
    public class GradeD : GiveWhenThenStudentResult
    {
        protected override string Name => $"Student Grade D";
        protected override double Score => 61;
        protected override double? ExamScore => null;
        protected override double FinalScore => 61;
        protected override double Presence => 0.85;
        protected override EnumFinalResult FinalResult => EnumFinalResult.Approved;
        protected override EnumGrade Grade => EnumGrade.D;
    }
}