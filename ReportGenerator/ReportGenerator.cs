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

    public class ReportGenerator
    {
        public IReport CreateReport(string reportType)
        {
            if (reportType == "PDF")
                return new PdfReport();
            else if (reportType == "Excel")
                return new ExcelReport();
            else if (reportType == "Word")
                return new WordReport();
            else
                throw new ArgumentException("Invalid report type");
        }
    }
}
