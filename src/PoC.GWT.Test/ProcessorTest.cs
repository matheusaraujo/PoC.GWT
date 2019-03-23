using PoC.GWT.Domain;
using PoC.GWT.Test.ComposedScenarios;
using PoC.GWT.Test.GiveWhenThen;
using PoC.GWT.Test.Scenarios;
using Xunit;

namespace PoC.GWT.Test
{
    public class ProcessorTest
    {
        private static void Test_Scenario(GiveWhenThen<Student, Result> scenario)
        {
            var processor = new Processor();

            scenario.Give(processor.Insert);
            scenario.When(processor.Run);
            scenario.Then(processor.Select);
        }

        [Fact]
        public void Test_ComposedScenario()
        {
            var processor = new Processor();

            var allScenarios = new AllScenarios();
            allScenarios.Give(processor.Insert);
            allScenarios.When(processor.Run);
            allScenarios.Then(processor.SelectAll);
        }

        [Fact]
        public void Test_ExamApproved()
        {
            Test_Scenario(new ExamApproved());
        }

        [Fact]
        public void Test_ExamDisapprovedGradeE()
        {
            Test_Scenario(new ExamDisapprovedGradeE());
        }

        [Fact]
        public void Test_ExamDisapprovedGradeF()
        {
            Test_Scenario(new ExamDisapprovedGradeF());
        }

        [Fact]
        public void Test_GradeA()
        {
            Test_Scenario(new GradeA());
        }

        [Fact]
        public void Test_GradeB()
        {
            Test_Scenario(new GradeB());
        }

        [Fact]
        public void Test_GradeC()
        {
            Test_Scenario(new GradeC());
        }

        [Fact]
        public void Test_GradeD()
        {
            Test_Scenario(new GradeD());
        }

        [Fact]
        public void Test_GradeF()
        {
            Test_Scenario(new GradeF());
        }

        [Fact]
        public void Test_InsufficientPresence()
        {
            Test_Scenario(new InsufficientPresence());
        }
    }
}