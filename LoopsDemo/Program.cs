//Arrays

string[] productId = new string[4];

productId[0] = "A123";
productId[1] = "B123";
productId[2] = "C123";
productId[3] = "D123";

/*Console.WriteLine($"First_ID: {productId[0]}");
Console.WriteLine($"Second_ID: {productId[1]}");
Console.WriteLine($"Third_ID: {productId[2]}");
Console.WriteLine($"Fourth_ID: {productId[3]}");*/

//foreach(variable in array )

foreach (string id in productId)
{
    Console.WriteLine($"ID: {id}");
}


int [] number= {13,30,100,456,123,457,654,9,34,23};

int sum = 0;
int lesssum = 0;

foreach(int i in number)
{
    if(i>50)
    {
        sum+=i;
        
    }

    else
    {
        lesssum+=i;
        
    }
}

Console.WriteLine($"Sum of greater than 50:{sum}");
Console.WriteLine($"Sum of less than 50:{lesssum}");