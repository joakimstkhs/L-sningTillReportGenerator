using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    
    public interface IReport
    {
        void Generate();
    }

    public class PdfReport : IReport
    {
        public void Generate() => Console.WriteLine("PDF Report Generated.");
    }

    public class ExcelReport : IReport
    {
        public void Generate() => Console.WriteLine("Excel Report Generated.");
    }

    public class WordReport : IReport
    {
        public void Generate() => Console.WriteLine("Word Report Generated.");
    }

    public class PowerPointReport : IReport
    {
        public void Generate() => Console.WriteLine("Power Point Report Generated.");
    }

    public class ReportGenerator
    {
        public IReport CreateReport(string reportType)
        {
            return reportType.ToLower() switch
            {
                "pdf" => new PdfReport(),
                "excel" => new ExcelReport(),
                "word" => new WordReport(),
                "powerpoint" => new PowerPointReport(),
                _ => throw new ArgumentException($"Invalid report type: {reportType}. Available types are: pdf, excel, word, powerpoint")
            };
        }
    }

}
