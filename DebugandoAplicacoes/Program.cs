#region Debugging
var numerosString = Console.ReadLine();
var numeros = numerosString.Split(' '); // Se estiver errada, você pode testar mudar o valor e avançar com o código
 
foreach (var numero in numeros)
{
    var numeroInt = int.Parse(numero);

    var aoQuadrado = Math.Pow(numeroInt, 2);

    Console.WriteLine($"{numeroInt} ao quadrado = {aoQuadrado}");
}
#endregion