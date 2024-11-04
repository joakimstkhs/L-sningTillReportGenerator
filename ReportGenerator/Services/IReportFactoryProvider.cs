namespace ReportGenerator.Services
{
    using ReportGenerator.Interfaces;
    using System.Collections.Generic;

    public interface IReportFactoryProvider
    {
        IReport GetReport(string reportType);
    }
}