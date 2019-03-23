using System;
using PoC.GWT.Domain;

namespace PoC.GWT
{
    public interface IProcessor
    {
        void Insert(Student input);
        void Run();
        Result Select(Guid studentId);
    }
}