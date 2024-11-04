namespace ReportGenerator.Services
{
    using ReportGenerator.Interfaces;
    using System.Collections.Generic;

    public interface IReportGeneratorService
    {
        IReport CreateReport(string reportType);
    }
}