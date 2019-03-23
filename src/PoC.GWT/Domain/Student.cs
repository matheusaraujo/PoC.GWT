using System;

namespace PoC.GWT.Domain
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
        public double? ExamScore { get; set; }

        public double Presence { get; set; }
    }
}