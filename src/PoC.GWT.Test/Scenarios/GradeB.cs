using PoC.GWT.Domain;
using PoC.GWT.Test.GivenWhenThen;

namespace PoC.GWT.Test.Scenarios
{
    public class GradeB : GivenWhenThenStudentResult
    {
        protected override string Name => $"Student Grade B";
        protected override double Score => 83;
        protected override double? ExamScore => null;
        protected override double FinalScore => 83;
        protected override double Presence => 1;
        protected override EnumFinalResult FinalResult => EnumFinalResult.Approved;
        protected override EnumGrade Grade => EnumGrade.B;
    }
}