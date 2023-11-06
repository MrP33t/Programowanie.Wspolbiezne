List<Thread> threads = new List<Thread>();
Random rnd = new Random();
var sums = new List<int>();

for (int i = 0; i < 10; i++) 
{
    // Without lock here can occur error
    threads.Add(new Thread(() => sums.Add(SumUp(rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 31) * 100))));
}

foreach(var t in threads)
{
    t.Start();
}
foreach (var t in threads)
{
    t.Join();
}
var sum = 0;
foreach (var s in sums)
{
    Console.WriteLine("+{0}", s);
    sum += s;
}
Console.WriteLine(" ={0}", sum);


int SumUp(int x, int y, int waitTime)
{
    Thread.Sleep(waitTime);
    return x + y;
}