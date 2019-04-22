using PoC.GWT.Domain;
using PoC.GWT.Test.GivenWhenThen;

namespace PoC.GWT.Test.Scenarios
{
    public class GradeA : GivenWhenThenStudentResult
    {
        protected override string Name => $"Student Grade A";
        protected override double Score => 95;
        protected override double? ExamScore => null;
        protected override double FinalScore => 95;
        protected override double Presence => 1;
        protected override EnumFinalResult FinalResult => EnumFinalResult.Approved;
        protected override EnumGrade Grade => EnumGrade.A;
    }
}