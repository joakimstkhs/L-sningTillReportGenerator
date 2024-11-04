namespace ReportGenerator.Services;

using Interfaces;
using System.Collections.Generic;

public interface IReportCreateService
{
    IReport CreateReport(string reportType);
    IEnumerable<string> GetAvailableReportTypes();
}