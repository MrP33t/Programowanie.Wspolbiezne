// See https://aka.ms/new-console-template for more information
var sum = 4 + 3;
Console.WriteLine(sum);
Lazy<int> lazySum = new Lazy<int>(() => 4 + 3);
Console.WriteLine(lazySum);
Console.WriteLine(lazySum.Value);
Console.WriteLine(lazySum);
