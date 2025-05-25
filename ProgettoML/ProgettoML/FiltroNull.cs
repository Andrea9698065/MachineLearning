using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class CsvNullColumnFilter
{
    public void FilterNullColumns(string inputPath, string outputPath)
    {
        var lines = File.ReadAllLines(inputPath);

        if (lines.Length == 0)
        {
            Console.WriteLine("Il file è vuoto.");
            return;
        }

        var header = lines[0].Split(',');
        int columnCount = header.Length;

        var validColumns = new List<int>();

        for (int col = 0; col < columnCount; col++)
        {
            bool allNullOrEmpty = true;

            for (int row = 1; row < lines.Length; row++)
            {
                var values = SplitCsvLine(lines[row]);
                if (col < values.Length && !string.IsNullOrWhiteSpace(values[col]))
                {
                    allNullOrEmpty = false;
                    break;
                }
            }

            if (!allNullOrEmpty)
            {
                validColumns.Add(col);
            }
        }

        // Scrivi solo le colonne valide
        using (var writer = new StreamWriter(outputPath))
        {
            foreach (var line in lines)
            {
                var values = SplitCsvLine(line);
                var filtered = validColumns.Select(i => i < values.Length ? values[i] : "").ToArray();
                writer.WriteLine(string.Join(",", filtered));
            }
        }

        Console.WriteLine("File filtrato scritto in: " + outputPath);
    }

    // Funzione base per gestione CSV semplificata (non gestisce virgolette complesse)
    private string[] SplitCsvLine(string line)
    {
        return line.Split(',');
    }
}
