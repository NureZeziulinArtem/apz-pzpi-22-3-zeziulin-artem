namespace BuilderReport
{
    public class HtmlReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public void BuildHeader()
        {
            _report.Header = "<header><h1>Report Header</h1></header>";
        }

        public void BuildBody()
        {
            _report.Body = "<main><p>This is the body of the report.</p></main>";
        }

        public void BuildFooter()
        {
            _report.Footer = "<footer><p>Report Footer</p></footer>";
        }

        public Report GetReport()
        {
            return _report;
        }

        public void Reset()
        {
            _report = new Report();
        }
    }
}

