namespace ReportGenerator.Reports
{
    using ReportGenerator.Base;

    public class WordReport : BaseReport
    {
        public override void Generate()
        {
            Console.WriteLine("Word report generated.");
        }

        public override string GetReportType() => "word";
    }
}