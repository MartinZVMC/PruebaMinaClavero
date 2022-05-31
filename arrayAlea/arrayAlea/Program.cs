// See https://aka.ms/new-console-template for more information

Console.Clear();
Console.WriteLine("Ingrese el tamaño de la lista: ");
var dato = int.Parse(Console.ReadLine());
int[] vector = new int[dato];
Random aleatorio = new Random();
for (int i = 0; i < vector.Length; i++)
{
    vector[i] = aleatorio.Next(100,200);
}
var pos = 0;
foreach (var c in vector)
{
    pos++;
    Console.WriteLine("Posicion: "+ pos + "--> " + c);
}
Console.WriteLine("Ingrese la posicion a cambiar: ");
var cambio = int.Parse(Console.ReadLine());
if (cambio > vector.Length || cambio < 1)
{
    Console.WriteLine("Posicion mal ingresada.");
}
else
{
    Console.WriteLine("Ingrese nuevo valor: ");
    var valor = int.Parse(Console.ReadLine());
    vector[cambio-1] = valor;
    pos = 0;
    foreach (var c in vector)
    {
        pos++;
        Console.WriteLine("Posicion: " + pos + "--> " + c);
    }

}


Console.ReadKey();
