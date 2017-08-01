using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestDemo;

namespace NunitTest
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidateFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");
            Console.WriteLine(result);
            Assert.False(result);
        }

        [Test]
        public void IsValidateFileName_GoodExtension_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("filewithbadextension.SLF");
            Console.WriteLine(result);
            Assert.True(result);
        }
    }
}

