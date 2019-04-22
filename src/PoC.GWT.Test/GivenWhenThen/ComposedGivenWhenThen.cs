using System;
using System.Collections.Generic;

namespace PoC.GWT.Test.GivenWhenThen
{
    public abstract class ComposedGivenWhenThen<T, T1, T2> where T : GivenWhenThen<T1, T2>
    {
        protected IList<T> Scenarios;
        public abstract void Given(Action<T1> given);
        public abstract void When(Action when);
        public abstract void Then(Func<IList<T2>> then);
    }
}