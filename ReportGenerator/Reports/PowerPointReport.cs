namespace ReportGenerator.Reports
{
    using ReportGenerator.Base;

    public class PowerPointReport : BaseReport
    {
        public override void Generate()
        {
            Console.WriteLine("PowerPoint report generated.");
        }

        public override string GetReportType() => "powerpoint";
    }
}