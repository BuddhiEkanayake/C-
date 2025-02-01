//for(<variable>, <condition> ,<iteration>;){}

/*for(int i=0; i<=10; i++)
{
    Console.WriteLine(i);
}
*/

for(int i =0; i<=100; i++)
{
    if(i%3==0)
    {
        Console.WriteLine($"{i}= Bizz");
    }

    if((i%3==0) && (i%5==0))
    {
        Console.WriteLine ($"{i}=Bizz Puzzl");
    }

    else
    {Console.WriteLine(i);}
}