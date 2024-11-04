namespace ReportGenerator.Base
{
    using ReportGenerator.Interfaces;
    using System;

    public abstract class BaseReport : IReport
    {
        public abstract void Generate();
     
        public abstract string GetReportType();

    }
}