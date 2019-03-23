using System;

namespace PoC.GWT.Test
{
    public abstract class GiveWhenThen<T1, T2>
    {
        public T1 Input;
        public abstract void Give(Action<T1> give);
        public abstract void When(Action when);
        public abstract void Then(Func<Guid, T2> then);
    }
}