using System;
using System.Text.RegularExpressions;

public class PlacaCarro
{
    public static void Formatar(string placaSuja)
    {
       // string placaSuja = "abc 1234"; // Exemplo de entrada com espaço
        string placaFormatada = FormatarPlacaCinza(placaSuja);
        
        Console.WriteLine(placaFormatada); // Saída: ABC-1234
        
    }
    
    public static string FormatarPlacaCinza(string placa)
    {
        if (string.IsNullOrWhiteSpace(placa)) return "";

        // 1. Remove qualquer coisa que não seja letra ou número
        string placaLimpa = Regex.Replace(placa, @"[^a-zA-Z0-9]", "");

        // 2. Verifica se tem o tamanho correto (7 caracteres)
        if (placaLimpa.Length != 7)
        {
            return placa; // Retorna original ou trate erro se preferir
        }

        // 3. Aplica a máscara: XXX-0000
        return $"{placaLimpa.Substring(0, 3)}-{placaLimpa.Substring(3)}".ToUpper();
    }
}
