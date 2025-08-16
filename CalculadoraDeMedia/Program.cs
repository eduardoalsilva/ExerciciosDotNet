// Calcula a média de 3 notas de um aluno.

using System.Net.Http.Headers;

List<double> notas = new List<double>();

Console.WriteLine("Calculadora de média. Entre com as notas");
Console.WriteLine("As notas devem ser de 0 a 10");

double nota;
double somaNotas = 0;

// Recebe as notas
while (notas.Count() < 3)
{
    Console.WriteLine($"Digite a nota da avaliação {notas.Count() + 1}");
    try
    {
        nota = double.Parse(Console.ReadLine());
        if (nota is >= 0 and <= 10)
        {
            notas.Add(nota);
            // Soma as notas
            somaNotas += notas[notas.Count() - 1];
        }
        else
        {
            Console.WriteLine("A nota deve estar entre 0 e 10");
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Nota incorreta. Tente novamente");
    }

}

// Calcula a media
double media = somaNotas / notas.Count();

bool aprovado = media >= 7;

Console.WriteLine($"Sua média: {media:F1}. Você foi {(aprovado ? "aprovado" : "reprovado")}.");
