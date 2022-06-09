var quilometrosPercorridosPeloVeiculo = 0d;
const double umKmMilhas = 1.609;

Console.WriteLine("Digite o total em quilometros que o seu carro percorreu: ");
quilometrosPercorridosPeloVeiculo = Convert.ToInt64(Console.ReadLine());
var milhasPercorridosPeloVeiculo = quilometrosPercorridosPeloVeiculo / umKmMilhas;
Console.WriteLine($"Seu veículo percorreu um total de {milhasPercorridosPeloVeiculo} milhas");

Console.WriteLine();
Console.WriteLine("Responda, qual categoria de operadores foram utilizadas nessa atividade?");
Console.WriteLine("Aritméticos, Console.Write() e Console.Read()");

Console.WriteLine();
Console.WriteLine("Responda, porque a variável quilometrosPercorridosPeloVeiculo não foi declarada com const?");
Console.WriteLine("Porque a variável quilometrosPercorridosPeloVeículo precisa ser dinâmica, ou seja, ter seu valor alterado em tempo de execução.");