/*int i=0;
 do{
   //always execute first statement
    Console.WriteLine(i);
    i++;
 }

 while(i<10);*/
//---------------------------------------------------------
  Random amount = new Random();

  int current=0;
  int index=1;

   do{
      current =amount.Next(1,10);
      Console.WriteLine($"{index}-{current}");
      index++;
   } while(current!=7);
   
//----------------------while loop-------------------------

 Random number= new Random();
  
  int newNumber= number.Next(1,11);
  Console.WriteLine($"First Number is= {newNumber}");

  while(newNumber>= 3)
  {
    Console.WriteLine(newNumber);
    newNumber= number.Next(1,11);
  }

  Console.WriteLine($"Last number is= {newNumber}");