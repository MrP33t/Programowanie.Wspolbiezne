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
        private Mutex[] mutexes;
        private Thread[] threads;

        private int _threadLimit;
        private bool _isFair;
        public CustomSemaphore(int threadLimit, bool isFair = false)
        {
            _threadLimit = threadLimit;
            _isFair = isFair;
            mutexes = new Mutex[threadLimit];
            threads = new Thread[threadLimit];
            for (int i = 0; i < threadLimit; i++)
            {
                mutexes[i] = new Mutex();
                threads[i] = null;
            }
        }
        public void Release()
        {
            for (int i = 0; i < _threadLimit; i++)
            {
                if (threads[i] == Thread.CurrentThread)
                {
                    mutexes[i].ReleaseMutex();
                    break;
                }
            }
        }

        public int Wait()
        {
            var index = WaitHandle.WaitAny(mutexes.ToArray());
            if (index != WaitHandle.WaitTimeout)
            {
                threads[index] = Thread.CurrentThread;
            }
            return index;
        }

    }
}
