List<int> lista2 = new List<int> { 1, 2, 2, 3, 3, 3, 4 };

var grupos = lista2.GroupBy(n => n)
                   .Select(g => new { Numero = g.Key, Cantidad = g.Count() });

foreach (var g in grupos)
{
    Console.WriteLine($"Número: {g.Numero}, Cantidad: {g.Cantidad}");

}
double promedio = lista2
    .Where(n => n > 1)
    .Average();

Console.WriteLine($"Promedio de números > 1: {promedio}");
