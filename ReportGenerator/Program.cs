using System;

namespace ReportGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new ReportGenerator();
            
            // Hämtar och genererar alla tillgängliga rapporttyper
            foreach (ReportType type in Enum.GetValues(typeof(ReportType)))
            {
                var report = generator.CreateReport(type);
                report.Generate();
            }
        }
    }
}