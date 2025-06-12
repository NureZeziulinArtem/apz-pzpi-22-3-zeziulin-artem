using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderReport
{
    public class ReportDirector
    {
        private IReportBuilder _builder;

        public ReportDirector(IReportBuilder builder)
        {
            _builder = builder;
        }

        public void ChangeBuilder(IReportBuilder builder)
        {
            _builder = builder;
        }

        public void Make()
        {
            _builder.BuildHeader();
            _builder.BuildBody();
            _builder.BuildFooter();
        }
    }
}

