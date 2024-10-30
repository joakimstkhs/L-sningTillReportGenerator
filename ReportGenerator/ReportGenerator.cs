using System;

namespace ReportGenerator
{
    public interface IReport
    {
        void Generate();
    }
    
    // Basrapportklass för olika rapporttyper
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

    public class ReportGenerator
    {
        // Skapar och returnerar en ny rapport av angiven typ
        public IReport CreateReport(ReportType type)
        {
            if (!Enum.IsDefined(typeof(ReportType), type))
            {
                throw new ArgumentException("Invalid report type.");
            }
            
            return new Report(type);
        }
    }
}