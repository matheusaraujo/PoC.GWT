using System;
using System.Collections.Generic;

namespace PoC.GWT.Test.GiveWhenThen
{
    public abstract class ComposedGiveWhenThen<T, T1, T2> where T : GiveWhenThen<T1, T2>
    {
        protected IList<T> Scenarios;
        public abstract void Give(Action<T1> give);
        public abstract void When(Action when);
        public abstract void Then(Func<IList<T2>> then);
    }
}