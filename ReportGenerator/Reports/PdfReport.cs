namespace ReportGenerator.Reports;

using Base;

public class PdfReport : BaseReport
{
    public override void Generate()
    {
        Console.WriteLine("Pdfer redo att läsas..."); 
    }

    public override string GetReportType() => "pdf";
}