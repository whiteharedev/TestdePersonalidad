var score = 0;
bool win = false;

Console.WriteLine("Contador de veces que pones XD");
Console.WriteLine("Did you win yet? " + win);

while (score < 10)
{
    var keyX = Console.ReadKey(true);
    if (keyX.Key == ConsoleKey.X)
    {
        var keyD = Console.ReadKey(true);
        if (keyD.Key == ConsoleKey.D)
        {
            score++;
            Console.WriteLine("XD " + score);
        }
    }
}

Console.WriteLine("Que graciosillo eres, no?");
Console.WriteLine("[Y]o soy muuuy gracioso!!! jajaja");
Console.WriteLine("[N]o soy nada gracioso, no tengo alma :(");
Console.WriteLine("Did you win yet? " + win);
while (score < 20)
{
    var keyYesNo = Console.ReadKey(true);
    if (keyYesNo.Key == ConsoleKey.Y)
    {
        score++;
        Console.WriteLine("JAJAJAJA! Score: " + score);
    }
    if (keyYesNo.Key == ConsoleKey.N)
    {
        Console.WriteLine("Un poco de amor propio... Otra vez. Score: " + score);
    }
}

win = true;
Console.WriteLine("Did you win yet? " + win);
if (win == true)
{
    Console.WriteLine("You win! Adios");
}

Console.ReadKey(true);