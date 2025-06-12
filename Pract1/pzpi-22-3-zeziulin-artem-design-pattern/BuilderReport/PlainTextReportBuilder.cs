using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderReport
{
    public class PlainTextReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public void BuildHeader()
        {
            _report.Header = "***** Report Header *****";
        }

        public void BuildBody()
        {
            _report.Body = "This is the body of the report.";
        }

        public void BuildFooter()
        {
            _report.Footer = "***** Report Footer *****";
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

