using System;
using SistemaEstacionamentoV2.Models;

namespace SistemaEstacionamentoV2.Utils;

public class Menu
{
    public static void Exibir()
    {
        Console.WriteLine("\nSistema de Estacionamento ");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Cadastrar veículo");
        Console.WriteLine("2 - Remover veículo");
        Console.WriteLine("3 - Listar veículos");
        Console.WriteLine("4 - Calcular tempo da estadia");
        Console.WriteLine("5 - Calcular valor da estadia");
        Console.WriteLine("6 - Sair");
    }
}
