using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Reflection.Metadata;
using System.Xml;
using SistemaEstacionamentoV2.Utils;
namespace SistemaEstacionamentoV2.Models;

public class Estacionamento
{
    private List<VeiculoDTO> veiculos = new List<VeiculoDTO>();
    private double precoInicial;

    public double PrecoInicial()
    {
       double precoInicial = double.Parse(Console.ReadLine());
       this.precoInicial = precoInicial;
       return this.precoInicial;
    }


    // Método para cadastrar um veículo 
    public void CadastrarVeiculo()
    {
        Console.WriteLine("Cadastrar veículo selecionado.");
        Console.WriteLine("Entre com a placa do veículo:");
        string placa1 = (string)Console.ReadLine();

        Console.WriteLine("Entre com a modelo do veículo:");
        string modelo1 = Console.ReadLine() as string;

        veiculos.Add(new VeiculoDTO(PlacaCarro.FormatarPlacaCinza(placa1), modelo1.ToUpper(), Util.HorarioEntrada()));
        Console.WriteLine("Veículo cadastrado com sucesso as " + Util.HorarioEntrada());
    }

    // Metodo de listar veículos
    public void ListarVeiculos()
    {
        Console.WriteLine("Lista veículos cadastrados.");
        // Lógica para listar veículos
        for (int i = 0; i < veiculos.Count; i++)
        {
            Console.WriteLine(" Veiculo " + veiculos[i].Placa.PadLeft(5, ' ') + " - " + veiculos[i].Modelo.PadLeft(10, ' ').ToUpper() + " - " + veiculos[i].HorarioEntrada);
        }
        Console.WriteLine("Total veiculos cadastrados = " + veiculos.Count);
    }

    // Metodo para remover veículo
    public void RemoverVeiculo()
    {
        Console.WriteLine("Entre com a placa para remover veículo selecionado. Formato  LLL-9999");
        string placa2 = Console.ReadLine() as string;
        veiculos.RemoveAll(v => v.Placa == placa2.ToUpper());
        Console.WriteLine("Veículo removido com sucesso.");
    }

    // Metodo para calcular tempo de estadia
    public void CalcularTempoEstadia()
    {
        Console.WriteLine("Calculando tempo da estadia");
        Console.WriteLine("Entre com a placa do veículo. Formato  LLL-9999");
        string placa3 = (string)Console.ReadLine();
        VeiculoDTO veiculoEncontrado = veiculos.Find(v => v.Placa == placa3.ToUpper());
        
        if (veiculoEncontrado != null)
        {
            Console.WriteLine("Veículo encontrado: " + veiculoEncontrado.ExibirDados());
            Console.WriteLine("Veículo Entrada: " + veiculoEncontrado.HorarioEntrada);
            Console.WriteLine("Total tempoda estadia: " + Util.DiferencaHoras(veiculoEncontrado.HorarioEntrada));   
        }
    }
    
    // Metodo para calcular valor da estadia  
    public void CalcularValorEstadia()
    {
        Console.WriteLine("Calculando valor da estadia");
        Console.WriteLine("Entre com a placa do veículo. Formato  LLL-9999");
        string placa4 = (string)Console.ReadLine();
        VeiculoDTO veiculoEncontrado2 = veiculos.Find(v => v.Placa == placa4.ToUpper());

        if (veiculoEncontrado2 != null)
        {
            //Console.WriteLine("Valor da Estadia: " + Util.CalcularValor(veiculoEncontrado2.HorarioEntrada as string)   );
            double valorEstadia = double.Parse(Util.CalcularValor(veiculoEncontrado2.HorarioEntrada as string).Replace("R$ ","")) + precoInicial ;
            //CultureInfo culturaBR = new CultureInfo("pt-BR"); // Cultura brasileira
            Console.WriteLine("Valor da Estadia sem formatação: " + valorEstadia);
        }
    }


}//fim da classe

