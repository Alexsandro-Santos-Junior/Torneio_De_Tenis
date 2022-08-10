Console.WriteLine("TORNEIO DE TÊNIS");
Console.WriteLine("----------------");
Console.WriteLine("Escreva seu Nome");
var Competidor = Console.ReadLine();
Console.WriteLine("Quantas Vitórias Você Conquistou?");
int Resultado =  Convert.ToInt32(Console.ReadLine());

if (Resultado <= 0) 
{
    Console.Write("Entrada |"); Console.WriteLine(" Saída");
    Console.WriteLine("P       |      ");
    Console.WriteLine("P       |      ");
    Console.WriteLine("P       |      ");
    Console.WriteLine("P       |    -1");
    Console.WriteLine("P       |      ");
    Console.WriteLine("P       |      ");
    //Console.WriteLine("P       |      ");
}
 else if (Resultado == 1)  
{
    Console.Write("Entrada "); Console.WriteLine(" Saída");
    Console.WriteLine("V       |      ");
    Console.WriteLine("P       |      ");
    Console.WriteLine("P       |      ");
    Console.WriteLine("P       |     3");
    Console.WriteLine("P       |      ");
    Console.WriteLine("P       |      ");
    //Console.WriteLine("P       |      ");
}
else if (Resultado == 2)
{
    Console.Write("Entrada "); Console.WriteLine(" Saída");
    Console.WriteLine("V       |      ");
    Console.WriteLine("P       |      ");
    Console.WriteLine("P       |      ");
    Console.WriteLine("P       |     3");
    Console.WriteLine("V       |      ");
    Console.WriteLine("P       |      ");
    //Console.WriteLine("P       |      ");
}
else if (Resultado == 3)
{
    Console.Write("Entrada "); Console.WriteLine(" Saída");
    Console.WriteLine("V       |      ");
    Console.WriteLine("V       |      ");
    Console.WriteLine("P       |      ");
    Console.WriteLine("P       |     2");
    Console.WriteLine("V       |      ");
    Console.WriteLine("P       |      ");
    //Console.WriteLine("P       |      ");
}

else if (Resultado == 4)
{
    Console.Write("Entrada "); Console.WriteLine(" Saída");
    Console.WriteLine("V       |      ");
    Console.WriteLine("P       |      ");
    Console.WriteLine("V       |      ");
    Console.WriteLine("V       |     2");
    Console.WriteLine("V       |      ");
    Console.WriteLine("P       |      ");
    //Console.WriteLine("P       |      ");
}
else if (Resultado == 5)
{
    Console.Write("Entrada "); Console.WriteLine(" Saída");
    Console.WriteLine("V       |      ");
    Console.WriteLine("V       |      ");
    Console.WriteLine("V       |      ");
    Console.WriteLine("P       |     1");
    Console.WriteLine("V       |      ");
    Console.WriteLine("V       |      ");
    //Console.WriteLine("P       |      ");
}
else if (Resultado == 6)
{
    Console.Write("Entrada "); Console.WriteLine(" Saída");
    Console.WriteLine("V       |      ");
    Console.WriteLine("V       |      ");
    Console.WriteLine("V       |      ");
    Console.WriteLine("V       |     1");
    Console.WriteLine("V       |      ");
    Console.WriteLine("V       |      ");
    //Console.WriteLine("V       |      ");
}else { Console.WriteLine("Número não é válido Escolha de 0 até 6"); }
Console.WriteLine("------------------------------");
Console.WriteLine($"O Competidor {Competidor} fez {Resultado} pontos");