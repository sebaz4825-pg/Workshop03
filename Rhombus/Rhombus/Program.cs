using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    int n;
    do
    {
        n = ConsoleExtension.GetInt("Ingrese el tamaño del rombo:  ");
        if (n < 3 || n % 2 == 0)
        {
            Console.WriteLine("El tamaño debe ser un número impar mayor o igual a 3.");
        }
    }
    while (n < 3 || n % 2 == 0);

    int m = n / 2;

    for (int i = 0; i < n; i++)
    {
        int d = Math.Abs(m - i);
        int outerSpaces = d;

        if (d == m)
        {
            Console.WriteLine($"{new string(' ', outerSpaces)}#");
        }
        else
        {
            int innerSpaces = 2 * (m - d) - 1;
            Console.WriteLine($"{new string(' ', outerSpaces)}#{new string(' ', innerSpaces)}#");
        }
    }

    do
    {
    answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;
Console.WriteLine("Gamer Over.");
