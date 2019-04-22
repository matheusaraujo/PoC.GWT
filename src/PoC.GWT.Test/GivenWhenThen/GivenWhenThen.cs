using System;

namespace PoC.GWT.Test.GivenWhenThen
{
    public abstract class GivenWhenThen<T1, T2>
    {
        public T1 Input;
        public abstract void Given(Action<T1> given);
        public abstract void When(Action when);
        public abstract void Then(Func<Guid, T2> then);
    }
}