// patten matching with C# swich expressions

//Value pattern

string color = "g";

var result= color switch 
{
    "r" => "color is red",
    "g" => "color is green",
    "b" => "color is blue",
    _ => "unknown color"
};

Console.WriteLine(result);


    