namespace ReportGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var reportGenerator = new ReportGenerator();
            
            var pdfReport = reportGenerator.CreateReport(ReportType.Pdf);
            pdfReport.Generate();

            var excelReport = reportGenerator.CreateReport(ReportType.Excel);
            excelReport.Generate();

            var wordReport = reportGenerator.CreateReport(ReportType.Word);
            wordReport.Generate();
            
            var powerPointReport = reportGenerator.CreateReport(ReportType.PowerPoint);
            powerPointReport.Generate();

            //try
            //{
            //    var invalidReport = reportGenerator.CreateReport("InvalidType");
            //    invalidReport.Generate();
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
