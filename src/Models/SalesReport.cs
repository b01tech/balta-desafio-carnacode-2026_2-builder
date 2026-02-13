namespace DesignPatternChallenge.Models;

public class SalesReport : IReport
{
    internal SalesReport() { }

    // obrigatórios
    public string Title { get; internal set; } = "Relatório de Vendas";
    public string Format { get; internal set; } = "PDF";
    public DateTime StartDate { get; internal set; } = DateTime.Now;
    public DateTime EndDate { get; internal set; } = StartDate.AddMonths(1);

    // header e footer
    public bool IncludeHeader { get; internal set; }
    public bool IncludeFooter { get; internal set; }
    public string HeaderText { get; internal set; }
    public string FooterText { get; internal set; }

    // gráficos e resumo
    public bool IncludeCharts { get; internal set; }
    public string ChartType { get; internal set; }
    public bool IncludeSummary { get; internal set; }

    // configurações de exibição
    public List<string> Columns { get; internal set; } = new();
    public List<string> Filters { get; internal set; } = new();
    public string SortBy { get; internal set; }
    public string GroupBy { get; internal set; }
    public bool IncludeTotals { get; internal set; }
    public string Orientation { get; internal set; }
    public string PageSize { get; internal set; }
    public bool IncludePageNumbers { get; internal set; }

    // configurações 
    public string CompanyLogo { get; internal set; }
    public string WaterMark { get; internal set; }
    public void Generate()
    {
        Console.WriteLine($"\n=== Gerando Relatório: {Title} ===");
        Console.WriteLine($"Formato: {Format}");
        Console.WriteLine($"Período: {StartDate:dd/MM/yyyy} a {EndDate:dd/MM/yyyy}");
        if (IncludeHeader)
            Console.WriteLine($"Cabeçalho: {HeaderText}");

        if (IncludeCharts)
            Console.WriteLine($"Gráfico: {ChartType}");

        Console.WriteLine($"Colunas: {string.Join(", ", Columns)}");

        if (Filters.Count > 0)
            Console.WriteLine($"Filtros: {string.Join(", ", Filters)}");

        if (!string.IsNullOrEmpty(GroupBy))
            Console.WriteLine($"Agrupado por: {GroupBy}");

        if (IncludeFooter)
            Console.WriteLine($"Rodapé: {FooterText}");

        Console.WriteLine("Relatório gerado com sucesso!");

    }
}
