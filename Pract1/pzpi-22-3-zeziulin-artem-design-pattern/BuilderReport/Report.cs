using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderReport
{
    public class Report
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }

        public void Show()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            Console.WriteLine(Footer);
        }
    }
}

