using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wspolbiezne.Zad5
{
    internal class FairCustomSemaphore
    {
        private readonly object lockObj = new object();

        private List<CustomSemaphore> WaitingQueue = new List<CustomSemaphore>();

        private CustomSemaphore RequestCustomSemaphore()
        {
            lock (lockObj)
            {
                CustomSemaphore s = new CustomSemaphore(1);
                s.Wait();
                return s;
            }
        }

        public void Release()
        {
            lock(lockObj)
            {
                WaitingQueue.RemoveAt(0);
                if (WaitingQueue.Count > 0 )
                {
                    WaitingQueue[0].Release();
                }
            }
        }

        public void Wait()
        {
            CustomSemaphore s = RequestCustomSemaphore();
            lock (lockObj)
            {
                WaitingQueue.Add(s);
                s.Release();

                if (WaitingQueue.Count > 1)
                {
                    s.Wait();
                }
            }
            s.Wait();
        }
    }
}
