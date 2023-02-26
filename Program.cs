//Ingresamos el valor inicial
Console.WriteLine("Ingrese una valor");
int num1 = Convert.ToInt32(Console.ReadLine());

//Ingresamos el valor final
Console.WriteLine("Ingrese otro valor");
int num2 = Convert.ToInt32(Console.ReadLine());

//Iteramos desde el valor inicial hasta el valor final
Console.Write("Los números pares son: ");
for (int i = num1; i <= num2; i++)
{
    //Verificamos si el número es par
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
