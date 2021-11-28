using System;

namespace SSL.Net.Threading
{
    public sealed class MultiThreadingRepeatEventArgs : EventArgs
    {
        public ulong RepeatCount
        {
            get;
            private set;
        }

        public MultiThreadingRepeatEventArgs(ulong repeatCount)
        {
            this.RepeatCount = repeatCount;
        }
    }
}
