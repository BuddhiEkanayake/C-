var dice=new Random();

var roll1 = dice.Next(1,7);
var roll2 = dice.Next(1,7);
var roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Value is {roll1} + {roll2} + {roll3} = {total}");

//total is greater than 14 yo won
//total is less than 14 you loose

if((roll1==roll2) || (roll2==roll3) || (roll3==roll1))
{
    Console.WriteLine("Add extra 2 marks in total value");
    total+=2;
}

Console.WriteLine($"New  total value = {total}");

if(total>14)
{
    Console.WriteLine("You won");
}

else
{
    Console.WriteLine("You loss");
}

