// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Wspolbiezne.Zad5;

int complexity = 400;
// To switch from fair to unfair change commented code on line 9 and 16

Random rnd = new Random();
//CustomSemaphore[] widelce = new CustomSemaphore[complexity];
FairCustomSemaphore[] widelce = new FairCustomSemaphore[complexity];
List<Thread> threads = new List<Thread>();
object lockObject = new object();

for (var i = 0; i < complexity; i++)
{
    //widelce[i] = new CustomSemaphore(1);
    widelce[i] = new FairCustomSemaphore();
}

for (var y = 0; y < complexity; y++)
{
    // Intresting (If we just pass y then y++ is going to run before function in thread filozof(y) and program will crash
    var tmp = y;
    threads.Add(new Thread(() => filozof(tmp)));
}

Stopwatch sw = Stopwatch.StartNew();
foreach (var t in threads)
{
    t.Start();
}

foreach (var t in threads)
{
    t.Join();
}
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);

void filozof(int miejsce)
{
    var miejsce2 = miejsce + 1;
    if (miejsce == (complexity - 1)) miejsce2 = 0;
    for (var x = 0; x < complexity; x++)
    {
        lock (lockObject)
        {
            //Console.WriteLine("+Filozof{0} podnosi widelce {0} | {1}...", miejsce, miejsce2);
            widelce[miejsce].Wait();
            widelce[miejsce2].Wait();
            //Thread.Sleep(1000); // Filozof je
        }
        widelce[miejsce].Release();
        widelce[miejsce2].Release();
        //Console.WriteLine("-Filozof{0} odklada widelce {0} | {1}...", miejsce, miejsce2);
    }
}
