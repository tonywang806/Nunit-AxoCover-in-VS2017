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
            if (!filenName.EndsWith(".SLF"))
            {
                return false;
            }
            return true;
        }
    }
}
