using System;
using System.Collections.Generic;



public class VeiculoDTO
{
    // Propriedades com get e set
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string HorarioEntrada { get; set; }

    // Construtor para facilitar a criação do objeto
    public VeiculoDTO(string placa, string modelo, string horarioentrada)
    {
        Placa = placa;        
        Modelo = modelo;     
        HorarioEntrada = horarioentrada;
    }

    // Método para exibir as informações do veículo
    public string ExibirDados()
    {
        return $"Veículo: Placa {Placa} e Modelo {Modelo} e Horário de Entrada {HorarioEntrada}";
    }


}

