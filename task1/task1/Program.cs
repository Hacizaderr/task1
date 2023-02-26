using System;
int mebleg = 789;
if (mebleg<100)
{
    Console.WriteLine(mebleg*0.95);
}
else if (mebleg >=100 && mebleg <= 1000)
{
    Console.WriteLine(mebleg*0.92);
}
else { Console.WriteLine(mebleg*0.9); }
