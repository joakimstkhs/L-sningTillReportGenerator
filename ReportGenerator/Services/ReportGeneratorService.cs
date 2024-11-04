namespace ReportGenerator.Services
{
    using ReportGenerator.Interfaces;
    using System.Collections.Generic;

    public class ReportGeneratorService : IReportGeneratorService
    {
        private readonly IReportFactoryProvider _factoryProvider;

        public ReportGeneratorService(IReportFactoryProvider factoryProvider)
        {
            _factoryProvider = factoryProvider ?? throw new ArgumentNullException(nameof(factoryProvider));
        }

        public IReport CreateReport(string reportType)
        {
            return _factoryProvider.GetReport(reportType);
        }

    }
}