using System;

namespace PoC.GWT.Domain
{
    public class Result
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public EnumGrade Grade { get; set; }
        public EnumFinalResult FinalResult { get; set; }
        public double FinalScore { get; set; }
    }
}