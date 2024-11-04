namespace ReportGenerator.Services
{
    using ReportGenerator.Interfaces;
    using System;
    using System.Collections.Generic;

    public class ReportCreateService(IReportFactoryProvider factoryProvider) : IReportCreateService
    {
        private readonly IReportFactoryProvider _factoryProvider = factoryProvider ?? throw new ArgumentNullException(nameof(factoryProvider));

        public IReport CreateReport(string reportType)
        {
            var report = _factoryProvider.GetReport(reportType);
            report.Generate();

            Console.WriteLine($"Report type: {report.GetReportType()} has been generated.");

            return report;
        }

        public IEnumerable<string> GetAvailableReportTypes()
        {
            return _factoryProvider.GetAvailableReportTypes();
        }
    }
}