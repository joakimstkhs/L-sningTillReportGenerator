namespace ReportGenerator.Reports;

using Base;

public class WordReport : BaseReport
{
    public override void Generate()
    {
        Console.WriteLine("Text redo att läsas...");
    }

    public override string GetReportType() => "word";
}