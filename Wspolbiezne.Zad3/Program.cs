// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
ReaderWriterLockSlim rwLock = new ReaderWriterLockSlim();

for (int i = 0; i <= 30; i++)
{
    if (rnd.Next(1,4) == 3) 
    {
        new Thread(() => Write("Pisarz" + rnd.Next(1,1000))).Start();
    }
    else
    {
        new Thread(() => Read("Czytelnik" + rnd.Next(1, 1000))).Start();
    }
}
void Write(string name)
{
    rwLock.EnterWriteLock();
    if (name.StartsWith("Pisarz")) name = "-" + name;
    Console.WriteLine("{0} wchodzi do czytelni!", name);
    Console.WriteLine("{0} pracuje...", name);
    Console.WriteLine("{0} pracuje...", name);
    Console.WriteLine("{0} pracuje...", name);
    Console.WriteLine("{0} pracuje...", name);
    Console.WriteLine("{0} Zakonczyl prace!", name);
    Console.WriteLine();
    rwLock.ExitWriteLock();
}
void Read(string name)
{
    rwLock.EnterReadLock();
    Console.WriteLine("{0} wchodzi do czytelni!", name);
    Console.WriteLine("{0} pracuje...", name);
    Console.WriteLine("{0} pracuje...", name);
    Console.WriteLine("{0} pracuje...", name);
    Console.WriteLine("{0} pracuje...", name);
    Console.WriteLine("{0} Zakonczyl prace!", name);
    Console.WriteLine();
    rwLock.ExitReadLock();
}
