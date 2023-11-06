// See https://aka.ms/new-console-template for more information

Random rnd = new Random();
Semaphore[] widelce = new Semaphore[5];
object lockObject = new object();

for (var i = 0; i < 5; i++)
{
    widelce[i] = new Semaphore(1, 1);
}

for (var y = 0; y < 5; y++)
{
    // Intresting (If we just pass y then y++ is going to run before function in thread filozof(y) and program will crash
    var tmp = y;
    new Thread(() => filozof(y)).Start();
}

void filozof(int miejsce)
{
    var miejsce2 = miejsce + 1;
    if (miejsce == 4) miejsce2 = 0;
    for (var x = 0; x < 5; x++)
    {
        lock (lockObject)
        {
            Console.WriteLine("+Filozof{0} podnosi widelce {0} | {1}...", miejsce, miejsce2);
            widelce[miejsce].WaitOne();
            widelce[miejsce2].WaitOne();
            Thread.Sleep(5); // Filozof je
        }
        widelce[miejsce].Release();
        widelce[miejsce2].Release();
        Console.WriteLine("-Filozof{0} odklada widelce {0} | {1}...", miejsce, miejsce2);
    }
}