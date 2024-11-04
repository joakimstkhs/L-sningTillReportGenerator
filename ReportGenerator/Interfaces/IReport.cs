namespace ReportGenerator.Interfaces
{
    public interface IReport
    {
        void Generate();
        string GetReportType();
    }
}