// See https://aka.ms/new-console-template for more information
const double umaMilha = 1.609344;

Console.Write("Quantos KM o veículo percorreu? ");
int quilometrosPercorridosPeloVeiculo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(value: $"Seu veículo percorreu um total de {quilometrosPercorridosPeloVeiculo / umaMilha} milhas");
