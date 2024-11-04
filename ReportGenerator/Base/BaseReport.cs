namespace ReportGenerator.Base;

using Interfaces;

public abstract class BaseReport : IReport
{
    public abstract void Generate();
     
    public abstract string GetReportType();

}