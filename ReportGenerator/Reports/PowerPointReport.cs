namespace ReportGenerator.Reports;

using Base;

public class PowerPointReport : BaseReport
{
    public override void Generate()
    {
        Console.WriteLine("PowerPoint redo att presenteras...");
    }

    public override string GetReportType() => "powerpoint";
}