using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Builders;

public class SalesReportBuilder : IReportBuilder
{
    private readonly SalesReport _report = new();
    public IReport Build() => _report;
    public IReportBuilder WithTitle(string title)
    {
        _report.Title = title;
        return this;
    }
    public IReportBuilder WithFormat(string format)
    {
        _report.Format = format;
        return this;
    }
    public IReportBuilder WithStartDate(DateTime startDate)
    {
        _report.StartDate = startDate;
        return this;
    }
    public IReportBuilder WithEndDate(DateTime endDate)
    {
        _report.EndDate = endDate;
        return this;
    }
    public IReportBuilder WithHeader(string header)
    {
        _report.IncludeHeader = true;
        _report.HeaderText = header;
        return this;
    }
    public IReportBuilder WithFooter(string footer)
    {
        _report.IncludeFooter = true;
        _report.FooterText = footer;
        return this;
    }
    public IReportBuilder WithCharts(string chartType)
    {
        _report.IncludeCharts = true;
        _report.ChartType = chartType;
        return this;
    }
    public IReportBuilder WithSummary()
    {
        _report.IncludeSummary = true;
        return this;
    }
    public IReportBuilder WithColumns(string column)
    {
        _report.Columns.Add(column);
        return this;
    }
    public IReportBuilder WithFilters(string filter)
    {
        _report.Filters.Add(filter);
        return this;
    }
    public IReportBuilder WithSortBy(string sortBy)
    {
        _report.SortBy = sortBy;
        return this;
    }
    public IReportBuilder WithGroupBy(string groupBy)
    {
        _report.GroupBy = groupBy;
        return this;
    }
    public IReportBuilder WithIncludeTotals()
    {
        _report.IncludeTotals = true;
        return this;
    }
    public IReportBuilder WithOrientation(string orientation)
    {
        _report.Orientation = orientation;
        return this;
    }
    public IReportBuilder WithPageSize(string pageSize)
    {
        _report.PageSize = pageSize;
        return this;
    }
    public IReportBuilder WithPageNumbers()
    {
        _report.IncludePageNumbers = true;
        return this;
    }
    public IReportBuilder WithCompanyLogo(string companyLogo)
    {
        _report.CompanyLogo = companyLogo;
        return this;
    }
    public IReportBuilder WithWaterMark(string waterMark)
    {
        _report.WaterMark = waterMark;
        return this;
    }
}
