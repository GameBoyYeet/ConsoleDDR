// See https://aka.ms/new-console-template for more information

Random random = new();
Console.WriteLine("Welcome to ConsoleDDR! To play, press the correct arrow key. Press any key to start, press Esc to quit at any time.");
Console.ReadKey(true);
if (Console.ReadKey().Key != ConsoleKey.Escape)
{
    while (true)
    {
        ConsoleKey cKey = ConsoleKey.Backspace;
        int num = random.Next(1, 5);
        if (num == 1)
        {
            Console.WriteLine("Left!");
            cKey = ConsoleKey.LeftArrow;
        }
        else if (num == 2)
        {
            Console.WriteLine("Up!");
            cKey = ConsoleKey.UpArrow;
        }
        else if (num == 3)
        {
            Console.WriteLine("Down!");
            cKey = ConsoleKey.DownArrow;
        }
        else if (num == 4)
        {
            Console.WriteLine("Right!");
            cKey = ConsoleKey.RightArrow;
        }
        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.Escape)
        {
            break;
        }
        else if (key != cKey)
        {
            Console.WriteLine("Oops! You messed up!");
        }
    }
}