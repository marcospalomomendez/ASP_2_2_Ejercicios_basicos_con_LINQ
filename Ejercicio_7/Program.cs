List<string> nombres = new List<string> { "Ana", "Luis", "Marta" };

var objetos = nombres.Select(n => new
{
    Nombre = n,
    Longitud = n.Length
});

foreach (var obj in objetos)
{
    Console.WriteLine($"Nombre: {obj.Nombre}, Longitud: {obj.Longitud}");
}
  
