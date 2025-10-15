List<int> lista = new List<int> { 2, 4, 4, 6, 8, 2, 10 };

var sinDuplicados = lista.Distinct();

Console.WriteLine("Lista sin duplicados:");
foreach (var n in sinDuplicados)
{
    Console.WriteLine(n);
}
int suma = sinDuplicados.Sum();
Console.WriteLine($"Suma de números únicos: {suma}");
var conteo = new
{
    Pares = lista.Count(n => n % 2 == 0),
    Impares = lista.Count(n => n % 2 != 0)
};

Console.WriteLine($"Pares: {conteo.Pares}, Impares: {conteo.Impares}");
