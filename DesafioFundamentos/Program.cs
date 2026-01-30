using SistemaEstacionamentoV2.Models;
using SistemaEstacionamentoV2.Utils;

public class Program
{
    static void Main(string[] args)
    {
       bool cont = true;

       Estacionamento estacionamento = new Estacionamento();      
       
       Console.WriteLine("Seja bem vindo ao sistema de estacionamento.");
       Console.WriteLine("Digite o preço inicial:");
       estacionamento.PrecoInicial();
       
       do              
       {

        Menu.Exibir();

        string opcao = (string) Console.ReadLine();
       
            switch (opcao)
            {
                case "1":
                    estacionamento.CadastrarVeiculo();
                    break;                    

                case "2":  
                    estacionamento.RemoverVeiculo();
                    break;

                case "3":
                    estacionamento.ListarVeiculos();
                    break;

                case "4":
                    estacionamento.CalcularTempoEstadia();                                       
                    break;

                case "5":
                    estacionamento.CalcularValorEstadia();                                              
                    break;
                
                case "6":
                    Console.WriteLine("Saindo do sistema.");
                    cont = false;
                    return;
                
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        Console.WriteLine("Pressione a tecla Enter para continuar");
        Console.ReadLine();  
        Console.Clear(); 

        } while (cont);  
    }    
    
}