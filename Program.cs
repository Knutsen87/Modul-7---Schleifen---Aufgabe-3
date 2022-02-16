// See https://aka.ms/new-console-template for more information


/*
 * Console.WriteLine("Bitte geben Sie ihrer Multiplikator ein: ");
int Zahl = Convert.ToInt32(Console.ReadLine());
MultiplikationList(Zahl);




static void MultiplikationList(int Zahl)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("{0} * {1} = {2}",Zahl, i, Zahl * i);
    }
}
*/


/*
Console.WriteLine("Bitte gebe den Wert für width(y) ein: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bitte gebe den Wert für height(x) ein: ");
int height = Convert.ToInt32(Console.ReadLine());
DrawRectangle(width, height);

static void DrawRectangle(int width, int height)
{

    for (int y = 0; y < width; y++)
    {
        for (int x = 0; x < height; x++)
        {
            Console.Write("#");
        }
        Console.WriteLine("#");
    }
}

*/





    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            Console.Write("{0}*{1}={2}", j, i, j * i);

            int spaces = (j * 10) - Console.CursorLeft;

            for (int k = 0; k <= spaces; k++)
            {
                Console.Write(" ");
            }
            
        }

    Console.WriteLine();
}

    Console.ReadKey();

