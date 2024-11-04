namespace ReportGenerator.Reports;

using Base;

public class ExcelReport : BaseReport
{
    public override void Generate()
    {
        Console.WriteLine("Läser in Ark...");
    }

    public override string GetReportType() => "excel";
}