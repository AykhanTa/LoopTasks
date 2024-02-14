// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Task1
int n = 5;
int m = 20;
int count = 0;
if (n < m)
{
    for (int i = n; i < m; i++)
    {
        if (i % 2 == 1)
        {
            count++;
        }
    }
}
else
{
    Console.WriteLine("Duzgun eded daxil et");
}
Console.WriteLine(count);

#endregion

#region Task2
//int n = 13;
//bool sade=true;
//if (n==2)
//{
//    sade = true;
//}
//else
//{


//    for (int i = 2; i < n ; i++)
//    {
//        if (n % i == 0)
//        {
//            sade=false;
//            break;
//        }
//    }
//}
//if (sade == true)
//{
//    Console.WriteLine("sadedir");
//}
//else
//{
//    Console.WriteLine("murekkebdir");
//}
#endregion

#region Task3
//int a = 18;
//int b = 7;
//if (a % b == 0)
//{
//    Console.WriteLine("Tam bolunur");
//}
//else
//{
//    Console.WriteLine("Bolunmur");
//}
#endregion


#region Task4
//int p1, p2, p3;
//p1 = 10;
//p2 = 5;
//p3 = 20;
//if (p1 < p2 && p1 < p3)
//{
//    Console.WriteLine(p2 + p3);
//}
//else if (p2 < p1 && p2 < p3)
//{
//    Console.WriteLine(p1 + p3);
//}
//else if (p3 < p2 && p3 < p1)
//{
//    Console.WriteLine(p2 + p1);
//}
//else
//{
//    Console.WriteLine(p1 + p2 + p3);
//}
#endregion