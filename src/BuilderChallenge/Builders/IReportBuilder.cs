using BuilderChallenge.Models;

namespace BuilderChallenge.Builders;

public interface IReportBuilder
{
    IReport Build();
    IReportBuilder WithTitle(string title);
    IReportBuilder WithFormat(string format);
    IReportBuilder WithStartDate(DateTime startDate);
    IReportBuilder WithEndDate(DateTime endDate);
    IReportBuilder WithHeader(string header);
    IReportBuilder WithFooter(string footer);
    IReportBuilder WithCharts(string chartType);
    IReportBuilder WithSummary();
    IReportBuilder WithColumns(string column);
    IReportBuilder WithColumns(IEnumerable<string> columns);
    IReportBuilder WithFilters(string filter);
    IReportBuilder WithSortBy(string sortBy);
    IReportBuilder WithGroupBy(string groupBy);
    IReportBuilder WithIncludeTotals();
    IReportBuilder WithOrientation(string orientation);
    IReportBuilder WithPageSize(string pageSize);
    IReportBuilder WithPageNumbers();
    IReportBuilder WithCompanyLogo(string companyLogo);
    IReportBuilder WithWaterMark(string waterMark);
}
