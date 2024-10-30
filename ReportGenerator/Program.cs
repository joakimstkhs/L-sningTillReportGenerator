using System;
using ReportGenerator;

namespace ReportGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ReportFactory();
            var generator = new ReportGenerator(factory);
            
            // Hämtar all tillgängliga rapporttyper
            foreach (ReportType type in Enum.GetValues(typeof(ReportType)))
            {
                try
                {
                    var report = generator.CreateReport(type);
                    report.Generate();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"{type}: {ex.Message}");
                }
            }
        }
    }
}