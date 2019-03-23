using PoC.GWT.Domain;
using System;
using System.Collections.Generic;

namespace PoC.GWT
{
    public interface IProcessor
    {
        void Insert(Student input);
        void Run();
        Result Select(Guid studentId);
        IList<Result> SelectAll();
    }
}