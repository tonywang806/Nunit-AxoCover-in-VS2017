using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string filenName)
        {
            if (string.IsNullOrEmpty(filenName)) {
                throw new ArgumentException(
                    "filename has to be provided");
            }

            if (!filenName.EndsWith(".SLF",StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }
            return true;
        }
    }
}
