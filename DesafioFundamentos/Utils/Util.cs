using System;
using System.Security.Cryptography.X509Certificates;
 using System.Globalization;

namespace SistemaEstacionamentoV2.Utils;

public class Util
{
    public static string HorarioEntrada()
    {
            DateTime agora = DateTime.Now; // Captura a data e hora atuais

            int _dia   = agora.Day;
            int _mes   = agora.Month;
            int _ano   = agora.Year;
            int _hora  = agora.Hour;
            int _minuto  = agora.Minute;
            int _segundo = agora.Second;

            // Exemplo com números inteiros
            string dia = _dia.ToString().PadLeft(2, '0');
            string mes = _mes.ToString().PadLeft(2, '0');
            string ano = _ano.ToString().PadLeft(4, '0');
            string hora = _hora.ToString().PadLeft(2, '0');
            string minuto = _minuto.ToString().PadLeft(2, '0');
            string segundo = _segundo.ToString().PadLeft(2, '0');

            // Console.WriteLine($"Dia: {dia}, Mês: {mes}, Ano: {ano}, Hora: {hora}, Minuto: {minuto}, Segundo: {segundo}");
            //return agora.ToString();
        return ($"{dia}/{mes}/{ano}  {hora}:{minuto}:{segundo}");  
    }

    public static string HorarioSaida()
    {
            DateTime agora = DateTime.Now; // Captura a data e hora atuais

            int _dia   = agora.Day;
            int _mes   = agora.Month;
            int _ano   = agora.Year;
            int _hora  = agora.Hour;
            int _minuto  = agora.Minute;
            int _segundo = agora.Second;

            // Exemplo com números inteiros
            string dia = _dia.ToString().PadLeft(2, '0');
            string mes = _mes.ToString().PadLeft(2, '0');
            string ano = _ano.ToString().PadLeft(4, '0');
            string hora = _hora.ToString().PadLeft(2, '0');
            string minuto = _minuto.ToString().PadLeft(2, '0');
            string segundo = _segundo.ToString().PadLeft(2, '0');

            // Console.WriteLine($"Dia: {dia}, Mês: {mes}, Ano: {ano}, Hora: {hora}, Minuto: {minuto}, Segundo: {segundo}");
            //return agora.ToString();
        return ($"{dia}/{mes}/{ano}  {hora}:{minuto}:{segundo}");  
    }



    public static string HorarioSaida3()
    {
            DateTime agora = DateTime.Now; // Captura a data e hora atuais

            int _dia   = agora.Day;
            int _mes   = agora.Month;
            int _ano   = agora.Year;
            int _hora  = agora.Hour;
            int _minuto  = agora.Minute;
            int _segundo = agora.Second;

            // Exemplo com números inteiros
            string dia = _dia.ToString().PadLeft(2, '0');
            string mes = _mes.ToString().PadLeft(2, '0');
            string ano = _ano.ToString().PadLeft(4, '0');
            string hora = _hora.ToString().PadLeft(2, '0');
            string minuto = _minuto.ToString().PadLeft(2, '0');
            string segundo = _segundo.ToString().PadLeft(2, '0');

            // Console.WriteLine($"Dia: {dia}, Mês: {mes}, Ano: {ano}, Hora: {hora}, Minuto: {minuto}, Segundo: {segundo}");
            //return agora.ToString();
        return ($"{ano},{mes},{dia},{hora},{minuto},{segundo}");  
    }

    public static string DiferencaHoras(string _HoraEntrada)
    {
       Console.WriteLine($"-----------------{_HoraEntrada}");

       Console.WriteLine($"-----------------{_HoraEntrada.Substring(0, 2)}");
       Console.WriteLine($"-----------------{_HoraEntrada.Substring(3, 2)}");
       Console.WriteLine($"-----------------{_HoraEntrada.Substring(6, 4)}");
       Console.WriteLine($"-----------------{_HoraEntrada.Substring(12, 2)}");
       Console.WriteLine($"-----------------{_HoraEntrada.Substring(15, 2)}");
       Console.WriteLine($"-----------------{_HoraEntrada.Substring(18, 2)}");

        DateTime dataHoraInicial = new DateTime(
                                                int.Parse(_HoraEntrada.Substring(6, 4)),
                                                int.Parse(_HoraEntrada.Substring(3, 2)),
                                                int.Parse(_HoraEntrada.Substring(0, 2)),
                                                int.Parse(_HoraEntrada.Substring(12, 2)),
                                                int.Parse(_HoraEntrada.Substring(15, 2)),
                                                int.Parse(_HoraEntrada.Substring(18, 2))
                                               );

        DateTime dataHoraFinal  = new DateTime( 
                                                int.Parse(Util.HorarioSaida().Substring(6, 4)),
                                                int.Parse(Util.HorarioSaida().Substring(3, 2)),
                                                int.Parse(Util.HorarioSaida().Substring(0, 2)),
                                                int.Parse(Util.HorarioSaida().Substring(12, 2)),
                                                int.Parse(Util.HorarioSaida().Substring(15, 2)),
                                                int.Parse(Util.HorarioSaida().Substring(18, 2))
                                              );

       TimeSpan diferenca = dataHoraFinal - dataHoraInicial;

       Console.WriteLine($"Diferença: {diferenca}"); // Saída: 2.04:30:00 (2 dias, 4 horas, 30 minutos)
       Console.WriteLine($"Dias: {diferenca.Days}"); // Saída: 2
       Console.WriteLine($"Horas (restantes): {diferenca.Hours}"); // Saída: 4
       Console.WriteLine($"Minutos (restantes): {diferenca.Minutes}"); // Saída: 30
       Console.WriteLine($"Total de Horas (decimal): {diferenca.TotalHours}"); // Saída: 52.5 (2 dias * 24h + 4.5h)
        
       return diferenca.ToString();
    }
    
    public static double TempoEstadia()
    {
        DateTime horaEntrada = new DateTime(2025, 12, 26, 8, 30, 00); // 26/12/2025 08:30:00
        DateTime horaSaida   = new DateTime(2025, 12, 27, 18, 15, 45);  // 26/12/2025 18:15:45
        
        Console.WriteLine($"- horaEntrada: {horaEntrada}");
        // Formatação
        string formato = "dd/MM/yyyy HH:mm:ss";
        Console.WriteLine($"Registro de Ponto:\nEntrada: {horaEntrada.ToString(formato)}\nSaída: {horaSaida.ToString(formato)}\n");

        // Cálculo do TimeSpan
        TimeSpan tempoTrabalhado = horaSaida - horaEntrada;

        // Exibição do TimeSpan
        Console.WriteLine($"Tempo Trabalhado (TimeSpan): {tempoTrabalhado.ToString()}"); // Saída: 9.15:45:00
        Console.WriteLine("Detalhes do Tempo Trabalhado:");
        Console.WriteLine($"- Dias: {tempoTrabalhado.Days}");
        Console.WriteLine($"- Horas: {tempoTrabalhado.Hours}");
        Console.WriteLine($"- Minutos: {tempoTrabalhado.Minutes}");
        Console.WriteLine($"- Segundos: {tempoTrabalhado.Seconds}");
        Console.WriteLine($"- Total de Horas: {tempoTrabalhado.TotalHours}");

        return tempoTrabalhado.TotalHours;
    }

    public static double CalcularValor2(string horaEntrada, string horaSaida)
    {
        horaSaida   = "12:00:00";

        TimeSpan entrada = TimeSpan.Parse(horaEntrada);
        TimeSpan saida = TimeSpan.Parse(horaSaida);
        TimeSpan diferenca = saida - entrada;

        double totalHoras = diferenca.TotalHours;
        double valorPorHora = 5.0; // Exemplo: R$ 5,00 por hora
        double valorTotal = Math.Ceiling(totalHoras) * valorPorHora; // Arredonda para cima

        return valorTotal;

    }

    public static string CalcularValor(string _HoraEntrada)
    {

        DateTime dataHoraInicial = new DateTime(
                                                int.Parse(_HoraEntrada.Substring(6, 4)),
                                                int.Parse(_HoraEntrada.Substring(3, 2)),
                                                int.Parse(_HoraEntrada.Substring(0, 2)),
                                                int.Parse(_HoraEntrada.Substring(12, 2)),
                                                int.Parse(_HoraEntrada.Substring(15, 2)),
                                                int.Parse(_HoraEntrada.Substring(18, 2))
                                               );

        DateTime dataHoraFinal  = new DateTime( 
                                                int.Parse(Util.HorarioSaida().Substring(6, 4)),
                                                int.Parse(Util.HorarioSaida().Substring(3, 2)),
                                                int.Parse(Util.HorarioSaida().Substring(0, 2)),
                                                int.Parse(Util.HorarioSaida().Substring(12, 2)),
                                                int.Parse(Util.HorarioSaida().Substring(15, 2)),
                                                int.Parse(Util.HorarioSaida().Substring(18, 2))
                                              );

       TimeSpan diferenca = dataHoraFinal - dataHoraInicial;
       
       double valorHora = 5.0;
       double valor = (diferenca.TotalHours * valorHora)  ;
       CultureInfo culturaBR = new CultureInfo("pt-BR"); // Cultura brasileira

       // Formata como Reais, com duas casas decimais
       string valorBR = valor.ToString("C", culturaBR); 
       // Saída: "R$ 9.876,54"

       return valorBR; // R$ 5,00 por hora
    }


}
