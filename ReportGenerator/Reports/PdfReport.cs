namespace ReportGenerator.Reports
{
    using ReportGenerator.Base;

    public class PdfReport : BaseReport
    {
        public override void Generate()
        {
            Console.WriteLine("Pdf report generated."); 
        }

        public override string GetReportType() => "pdf";
    }
}