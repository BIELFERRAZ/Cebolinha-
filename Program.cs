string frase;

Console.WriteLine("Por favor , Escreva uma Frase");
frase = Console.ReadLine()!;

string novafrase = frase
.Replace ("r","l"!)
.Replace ("R" , "L"! );

Console.WriteLine(novafrase);