using System.Collections;
using System.Linq;
using System.Diagnostics;
// i v
//   0 1 2 3 4 5 6 7 8 9   
//   1 5 4 1 3 4 7 4 1 2 
// j ^ ^ ^

int size = 10;
int m=3;

int[] array = Enumerable.Range(1, size)
                        .Select(item.Random.Shared.Next(10)) // .Select(new.Random().Next(10)) 
                        .ToArray();

System.Console.WriteLine($"[string.Join(", ", array}]");    

Stopwatch sw = new();
sw.Start();
int max=0;

for (int i=0; i<array.Length-m; i++)
{
    int t=0;
    for (int j = i; j< i+m;j++) t+=array[j];
    if(t>max) max=t;
}
sw.Stop();

System.Console.WriteLine(max);
System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
System.Console.WriteLine(max);