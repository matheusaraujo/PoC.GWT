using System;
using System.Collections.Generic;
using System.Linq;
using PoC.GWT.Domain;

namespace PoC.GWT
{
    public class Processor : IProcessor
    {
        private readonly IList<Result> _results;
        private readonly IList<Student> _students;

        public Processor()
        {
            _students = new List<Student>();
            _results = new List<Result>();
        }

        public void Insert(Student input)
        {
            _students.Add(input);
        }

        public void Run()
        {
            foreach (var student in _students)
                _results.Add(Calc(student));
        }

        public Result Select(Guid studentId)
        {
            return _results.SingleOrDefault(i => i.StudentId == studentId);
        }

        private static Result Calc(Student student)
        {
            var result = new Result
            {
                Id = Guid.NewGuid(),
                StudentId = student.Id
            };

            if (student.Presence < 0.75)
            {
                result.Grade = EnumGrade.F;
                result.FinalResult = EnumFinalResult.Disapproved;
                result.FinalScore = 0;
            }
            else if (student.Score >= 90)
            {
                result.Grade = EnumGrade.A;
                result.FinalResult = EnumFinalResult.Approved;
                result.FinalScore = student.Score;
            }
            else if (student.Score >= 80)
            {
                result.Grade = EnumGrade.B;
                result.FinalResult = EnumFinalResult.Approved;
                result.FinalScore = student.Score;
            }
            else if (student.Score >= 70)
            {
                result.Grade = EnumGrade.C;
                result.FinalResult = EnumFinalResult.Approved;
                result.FinalScore = student.Score;
            }
            else if (student.Score >= 60)
            {
                result.Grade = EnumGrade.D;
                result.FinalResult = EnumFinalResult.Approved;
                result.FinalScore = student.Score;
            }
            else if (student.Score >= 40)
            {
                var finalScore = (student.Score + student.ExamScore ?? 0) / 2;
                if (finalScore >= 60)
                {
                    result.Grade = EnumGrade.D;
                    result.FinalResult = EnumFinalResult.Approved;
                    result.FinalScore = 60;
                }
                else if (finalScore >= 40)
                {
                    result.Grade = EnumGrade.E;
                    result.FinalResult = EnumFinalResult.Disapproved;
                    result.FinalScore = finalScore;
                }
                else
                {
                    result.Grade = EnumGrade.F;
                    result.FinalResult = EnumFinalResult.Disapproved;
                    result.FinalScore = finalScore;
                }
            }
            else
            {
                result.Grade = EnumGrade.F;
                result.FinalResult = EnumFinalResult.Disapproved;
                result.FinalScore = student.Score;
            }

            return result;
        }

        public IList<Result> SelectAll()
        {
            return _results.OrderBy(r => r.Grade).ThenByDescending(r => r.FinalScore).ToList();
        }
    }
}