using DesignPatternChallenge.Models;
namespace DesignPatternChallenge.Builders;

public interface IReportBuilder
{
    IReport Build();
    IReportBuilder WithTitle(string title);
    IReportBuilder WithFormat(string format);
    IReportBuilder WithStartDate(DateTime startDate);
    IReportBuilder WithEndDate(DateTime endDate);
}
