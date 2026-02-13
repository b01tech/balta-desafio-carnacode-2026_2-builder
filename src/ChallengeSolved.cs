// Solução: Usando Builder para criar relatórios customizados
using DesignPatternChallenge.Builders;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Relatórios ===");
        var builder = new SalesReportBuilder();

        var report1 = builder
            .WithTitle("Vendas Q1")
            .WithFormat("PDF")
            .WithStartDate(new DateTime(2025, 1, 1))
            .WithEndDate(new DateTime(2025, 3, 31))
            .WithHeader("Relatório Trimestral")
            .WithCharts("Barras")
            .WithColumns(new List<string> { "Produto", "Valor" })
            .Build();

        report1.Generate();

        var report2 = builder
            .WithTitle("Vendas Q2")
            .WithFormat("Excel")
            .WithStartDate(new DateTime(2024, 1, 1))
            .WithEndDate(new DateTime(2024, 3, 31))
            .WithHeader("Relatório Trimestral")
            .WithCharts("Barras")
            .WithColumns("Vendedor")
            .WithColumns("Região")
            .WithColumns("Total")
            .WithCharts("Line")
            .WithGroupBy("Região")
            .WithIncludeTotals()
            .WithWaterMark("Confidencial")
            .WithPageNumbers()
            .Build();

        report2.Generate();

        Console.ReadKey();
    }
}
