// patten matching with C# swich expressions

//Value pattern

/*string color = "g";

var result= color switch 
{
    "r" => "color is red",
    "g" => "color is green",
    "b" => "color is blue",
    _ => "unknown color"
};

Console.WriteLine(result);

//Type pattern

int age=20;
string name="John";
List<string> colors = new List<string> { "red", "green", "blue" };
var numbers= new int[] { 1, 2, 3, 4, 5 };
double salary= 1000.00;


object CheckType(object val) => val switch
{
    int => "integer Type",
    string => "string Type",
    List<string> => "List of string Type",
    Array => "Array Type",
    _ => "unknown Type"
};

Console.WriteLine(CheckType(age));
Console.WriteLine(CheckType(name));
Console.WriteLine(CheckType(colors));
Console.WriteLine(CheckType(numbers));
Console.WriteLine(CheckType(salary));*/


 //Relation Pattern

    var numbers = new List<int>{1,2,4,-10,67,-2,34,0};

    foreach(var num in numbers)
    {
        var res= num switch
        {
            > 0 => $"{num} is positive",
            0 => $"{num} is zero",
            < 0 => $"{num} is negative",
            
        };
        Console.WriteLine(res);
    }
