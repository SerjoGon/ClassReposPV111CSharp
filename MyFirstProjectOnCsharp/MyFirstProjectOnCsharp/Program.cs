// See https://aka.ms/new-console-template for more information

Console.WriteLine("It's easy to win forgiveness for being wrong; \n Being right is what gets you into real trouble.\n Bjarne Stroustrup");
Console.WriteLine("Введите числа!");
//List<String> list = new List<String> { };
//for(int i = 0; i < list.Count; i++)
//{
//list[i] = Console.ReadLine();
//}
int n = 5;
String[] list = new String[n];
//Console.WriteLine(list);
//for(int i = 0; i < n; i++)
//{
//    Console.WriteLine("Введите число для индекса {0}",i); 
//    list[i] = Console.ReadLine();
////}
int[] massive = new int[5];
for(int i = 0; i < massive.Length; i++)
{
    Console.WriteLine("Введите число для индекса {0}",i);
    massive[i] = Int32.Parse(Console.ReadLine());
}
int summary = 0, multiply = 1, max , min ;
min = massive[0];
max = massive[0];

for(int i = massive.Length - 1;i >0 ; i--)
{
    summary += massive[i];
    multiply *= massive[i];
    if (min < massive[i]) { min = massive[i]; };
    if (max < massive[i]) { max = massive[i]; };
}
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(multiply);
