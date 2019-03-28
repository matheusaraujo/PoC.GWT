using PoC.GWT.Domain;
using PoC.GWT.Test.GiveWhenThen;

namespace PoC.GWT.Test.Scenarios
{
    public class GradeC : GiveWhenThenStudentResult
    {
        protected override string Name => $"Student Grade C";
        protected override double Score => 77;
        protected override double? ExamScore => null;
        protected override double FinalScore => 77;
        protected override double Presence => 1;
        protected override EnumFinalResult FinalResult => EnumFinalResult.Approved;
        protected override EnumGrade Grade => EnumGrade.C;
    }
}