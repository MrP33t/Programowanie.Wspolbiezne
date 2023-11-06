using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wspolbiezne.Zad5
{
    internal class CustomSemaphore
    {
        bool _isFair;
        int waiting;
        int _maxQueue;

        
        private IDictionary<Thread, Stopwatch> threads = new Dictionary<Thread, Stopwatch>();

        private readonly object _lock = new object();
        public CustomSemaphore(int maxQueue, bool isFair = false)
        {
            _isFair = isFair;
            _maxQueue = maxQueue;
            waiting = 0;
        }
        public void Release()
        {
            Monitor.Enter(_lock);
            waiting--;
            Monitor.Exit(_lock);
        }

        private void FairRelease()
        {
            Monitor.Enter(_lock);
            threads.Remove(Thread.CurrentThread);
            waiting--;
            Monitor.Exit(_lock);
        }

        public void WaitOne()
        {
            Monitor.Enter(_lock);
            waiting++;
            if (waiting > _maxQueue)
            {
                Monitor.Wait(_lock);
            }
            Monitor.Exit(_lock);
        }

        private void FairWaitOne()
        {
            Monitor.Enter(_lock);
            threads.Add(Thread.CurrentThread, Stopwatch.StartNew());
            waiting++;
            if (waiting > _maxQueue)
            {
                Monitor.Wait(_lock);
            }
            Monitor.Exit(_lock);
        }
    }
}
