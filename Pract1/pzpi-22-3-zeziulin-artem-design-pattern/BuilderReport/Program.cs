namespace BuilderReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IReportBuilder plainBuilder = new PlainTextReportBuilder();
            var director = new ReportDirector(plainBuilder);
            director.Make();
            var plainReport = plainBuilder.GetReport();
            plainReport.Show();

            Console.WriteLine();

            IReportBuilder htmlBuilder = new HtmlReportBuilder();
            director.ChangeBuilder(htmlBuilder);
            director.Make();
            var htmlReport = htmlBuilder.GetReport();
            htmlReport.Show();
        }
    }
}

