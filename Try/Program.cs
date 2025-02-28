// See https://aka.ms/new-console-template for more information
int marks;
Console.WriteLine("Enter your marks:");

marks = Convert.ToInt32(Console.ReadLine());
 if(marks<35){
    Console.WriteLine("You have failed");
 }
else if(marks>=35 && marks<50){
        Console.WriteLine("You have passed");
}
else if (marks>= 50 && marks<65){
    Console.WriteLine("You have passed with 2nd class");
}
else{
    Console.WriteLine("You have passed with 1st class");
}