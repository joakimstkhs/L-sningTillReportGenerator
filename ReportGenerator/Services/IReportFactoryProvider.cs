namespace ReportGenerator.Services;

using Interfaces;

public interface IReportFactoryProvider
{
    IReport GetReport(string reportType);
    IEnumerable<string> GetAvailableReportTypes();
}