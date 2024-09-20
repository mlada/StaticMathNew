// See https://aka.ms/new-console-template for more information

using ClassLibrary1;

int[] a = { 7, 3, 4, 1, 8 };
int[] b = { 0, 1 };

int res1 = Class1.Func1(a,b);

Console.WriteLine("multiplication of non-zero components of array a, whose indexes are stored in array b = ");
Console.WriteLine(res1);

Element res2 = Class1.Func2(a);

Console.WriteLine("minimum element = " + res2.value.ToString() + " and index = " + res2.index.ToString());
 
double[] c = { 1.34, 3.5, 4, 0, 8.5 };

double[] res3 = Class1.Func3(c);

Console.WriteLine("reverse c = ");
Console.WriteLine(string.Join(";", res3));