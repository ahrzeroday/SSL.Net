using System;

namespace SSL.Net.Threading
{
    public sealed class MultiThreadingProgressEventArgs : EventArgs
    {
        public object Result
        {
            get;
            private set;
        }

        public MultiThreadingProgressEventArgs(object result)
        {
            this.Result = result;
        }
    }
}
