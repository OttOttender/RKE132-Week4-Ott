
int sum = 0;

for(int i = 0; i < 11; i++) //i-- =  i - 1
{
    Console.WriteLine($"i = {i}");//{ainult visualiseerimiseks ei muuda i = v22rtust}
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; 
}

//Console.WriteLine($"Final total {sum}");