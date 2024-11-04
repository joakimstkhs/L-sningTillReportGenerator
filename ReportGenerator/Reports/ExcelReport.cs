namespace ReportGenerator.Reports
{
    using ReportGenerator.Base;

    public class ExcelReport : BaseReport
    {
        public override void Generate()
        {
            Console.WriteLine("Excel report generated.");
        }

        public override string GetReportType() => "excel";
    }
}