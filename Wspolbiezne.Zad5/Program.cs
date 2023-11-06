// See https://aka.ms/new-console-template for more information
using Wspolbiezne.Zad5;

Semaphore semaphore = new CustomSemaphore(1);

new Thread(() => test()).Start();

void test()
{
    semaphore.WaitOne();
    semaphore.Release();
}
