using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderReport
{
    public interface IReportBuilder
    {
        void Reset();
        void BuildHeader();
        void BuildBody();
        void BuildFooter();
        Report GetReport();
    }
}

