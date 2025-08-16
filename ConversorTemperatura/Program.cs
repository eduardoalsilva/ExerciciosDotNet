// Exercício 2: Conversor de Temperaturas
using ConversorTemperatura.Models;


double temperatura;

bool exibirMenu = true;

string opcao;

while (exibirMenu)
{
    // Console.Clear();
    Console.WriteLine("Escolha a temperatura que deseja converter");
    Console.WriteLine("1. Fahrenheit => Celsius");
    Console.WriteLine("2. Celsius => Fahrenheit");
    Console.WriteLine("3. Sair");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Converta Fahrenheit em Celsius:");
            temperatura = double.Parse(Console.ReadLine());
            Celsius celsius = new Celsius(temperatura);
            celsius.ConverterTemperatura();
            break;

        case "2":
            Console.WriteLine("Converta Celsius em Fahrenheit:");
            temperatura = double.Parse(Console.ReadLine());
            Fahrenheit fahrenheit = new Fahrenheit(temperatura);
            fahrenheit.ConverterTemperatura();
            break;

        case "3":
            Console.WriteLine("Saindo do programa...");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção incorreta!");
            break;
    }
}
