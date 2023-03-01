int y = 0;
int x = 0;
string input = string.Empty;
string result = string.Empty;

do
{
    System.Console.WriteLine("enter a direction");
    input = Console.ReadLine()!;
}
while (!IsValid(input));

bool IsValid(string input)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != '<' && input[i] != '>' && input[i] != '^' && input[i] != 'v')
        {
            return false;
        }
    }
    return true;
}

string PutOutDirection()
{
    for (int i = 0; i < input.Length; i++)
    {
        switch (input[i])
        {
            case '^':
                y++;
                break;

            case 'v':
                y--;
                break;
            case '<':
                x--;
                break;

            case '>':
                x++;
                break;
        }
    }

    System.Console.Write("the rover is: ");
    if (x == 0 && y == 0)
    {
        System.Console.Write("in the base station");
    }
    if (x > 0)
    {
        System.Console.Write($"{x}m to the East");
    }
    else if (x < 0)
    {
        System.Console.Write($"{x * -1}m to the West");
    }
    if (y != 0 && x != 0)
    {
        System.Console.Write(" and ");
    }
    if (y > 0)
    {
        System.Console.Write($"{y}m to the North");
    }
    if (y < 0)
    {
        System.Console.Write($"{y * -1}m to the South");
    }
    System.Console.WriteLine(" ");

    return input;
}

double PrintManhattanDistanceAndLinearDistance()
{
    if (x > 0)
    {
        result += Direction("East", x);
    }
    else if (x < 0)
    {
        x *= -1; result += Direction("West", x);
    }
    if (y > 0)
    {
        result += Direction("North", y);
    }
    else if (y < 0)
    {
        y *= -1; result += Direction("South", y);
    }
    
    string Direction(string direction, int metres)
    {
        return $"{metres}m to the {direction}";
    }

    double Distances = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(x, 2));
    Console.Write($"Linear distance = {double.Round(Distances, 2)}m; Manhattan distance = {x + y}m");

    return Distances;
}

PutOutDirection();
PrintManhattanDistanceAndLinearDistance();