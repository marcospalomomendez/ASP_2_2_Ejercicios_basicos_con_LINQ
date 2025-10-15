int[] numeros = { 5, 12, 8, 23, 4, 16, 19, 7, 10, 3 };

var mayoresQue10 = numeros.Where(n => n > 10);

Console.WriteLine("Números mayores que 10:");
foreach (var n in mayoresQue10)
{
    Console.WriteLine(n);

}
var resultado = numeros
    .Where(n => n > 10)
    .OrderByDescending(n => n)
    .Select(n => n * 2);

Console.WriteLine("Números >10, ordenados desc, multiplicados por 2:");
foreach (var n in resultado)
{
    Console.WriteLine(n);
}
