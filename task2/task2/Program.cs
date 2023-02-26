int saat = 7;
if (saat <=3)
{
    Console.WriteLine(saat*1);
}
else if (saat >3 && saat<=5)
{
    Console.WriteLine(3*1+(saat-3)*0.8);
}
else if (saat >5 && saat <= 8)
{
    Console.WriteLine(3*1+2*0.8+(saat-5)*0.5);
}
else if (saat >8)
{
    Console.WriteLine(saat*0.25);
}