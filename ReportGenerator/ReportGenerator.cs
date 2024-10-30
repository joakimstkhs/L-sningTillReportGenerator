using System;

namespace ReportGenerator
{
    public interface IReport
    {
        void Generate();
    }
    
    public class Report : IReport
    {
        private readonly ReportType _reportType;

        public Report(ReportType reportType)
        {
            _reportType = reportType;
        }

        public void Generate()
        {
            Console.WriteLine($"{_reportType} Report Generated.");
        }
    }

    // Tillgängliga rapporttyper
    public enum ReportType
    {
        Pdf,
        Excel,
        Word,
        PowerPoint
    }

    public interface IReportFactory
    {
        IReport CreateReport(ReportType type);
    }

    public class ReportFactory : IReportFactory
    {
        public IReport CreateReport(ReportType type)
        {
            return new Report(type);
        }
    }

    public class ReportGenerator
    {
        private readonly IReportFactory _factory;

        public ReportGenerator(IReportFactory factory)
        {
            _factory = factory;
        }

        public IReport CreateReport(ReportType type)
        {
            return _factory.CreateReport(type);
        }
    }
}