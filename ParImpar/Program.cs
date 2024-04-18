int ni = 0, nf = 0, c = 0, npi;
Console.WriteLine("Digite o valor inicial: ");
ni = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor final: ");
nf = int.Parse(Console.ReadLine());


if (ni == nf)
{
    Console.WriteLine("Por favor digite valores diferentes");
}
else
{
    if (ni > nf)
    {
        c = ni;
        npi = ni;
        while (c > nf + 1)
        {
            npi--;
            c--;
            if ((npi % 2) == 0)
            {
                Console.WriteLine($"{npi} é par");
            }
            else
            {
                Console.WriteLine($"{npi} é impar");
            }

        }
    }
    else
    {
        c = ni;
        npi = ni;
        while (c < nf - 1)
        {
            npi++;
            c++;
            if ((npi % 2) == 0)
            {
                Console.WriteLine($"{npi} é par");
            }
            else
            {
                Console.WriteLine($"{npi} é impar");
            }
        }
    }
}


