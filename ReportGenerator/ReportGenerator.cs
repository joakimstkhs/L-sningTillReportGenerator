using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public enum ReportType
    {
        Pdf,
        Excel,
        Word,
        PowerPoint
    }
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
        public IReport CreateReport(ReportType reportType)
        {
            return reportType switch
            {
                ReportType.Pdf => new PdfReport(),
                ReportType.Excel => new ExcelReport(),
                ReportType.Word => new WordReport(),
                ReportType.PowerPoint => new PowerPointReport(),
                _ => throw new ArgumentOutOfRangeException(nameof(reportType), reportType, "Invalid report type specified.")
            };
        }
    }

}
