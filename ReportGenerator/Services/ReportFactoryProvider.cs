

namespace ReportGenerator.Services;

using System;
using System.Collections.Generic;
using Interfaces;
using Reports;

public class ReportFactoryProvider : IReportFactoryProvider
{
    private readonly IReadOnlyDictionary<string, Func<IReport>> _reportFactories = new Dictionary<string, Func<IReport>>(StringComparer.OrdinalIgnoreCase)
    {
        { "pdf", () => new PdfReport() },
        { "excel", () => new ExcelReport() },
        { "word", () => new WordReport() },
        { "powerpoint", () => new PowerPointReport() }
    };

    public IReport GetReport(string reportType)
    {
        if (!_reportFactories.TryGetValue(reportType, out var createReport))
        {
            throw new ArgumentException(
                $"Invalid report type: '{reportType}'. Available types are: {string.Join(", ", GetAvailableReportTypes())}");
        }

        return createReport();
    }

    public IEnumerable<string> GetAvailableReportTypes() => _reportFactories.Keys;
}