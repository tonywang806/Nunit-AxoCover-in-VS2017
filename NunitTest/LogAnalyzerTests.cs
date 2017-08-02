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
            //Arrange
            LogAnalyzer analyzer = new LogAnalyzer();

            //Act
            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

            //Assert
            Assert.False(result);
        }

        [TestCase("filewithgoodextension.SLF")]
        [TestCase("filewithgoodextension.slf")]
        public void IsValidateFileName_ExtensionUppercase_ReturnsTrue(string file)
        {
            //Arrange
            LogAnalyzer analyzer = new LogAnalyzer();

            //Act
            bool result = analyzer.IsValidLogFileName(file);

            //Assert
            Assert.True(result);
        }

        [Test]
        public void IsValidFileName_EmptyFileName_ThrowException()
        {
            ////Usage 1------------------------------------------
            ////Arrange
            //LogAnalyzer analyzer = new LogAnalyzer();

            ////Act

            ////Assert
            //Assert.That(() => analyzer.IsValidLogFileName(string.Empty),
            //    Throws.TypeOf<ArgumentException>());
            //----------------------------------------------------

            //Usage 2------------------------------------------
            //Arrange
            LogAnalyzer analyzer = new LogAnalyzer();

            //Act
            var ex = Assert.Catch<Exception>(() => analyzer.IsValidLogFileName(string.Empty));

            //Assert
            StringAssert.Contains("filename has to be provided", ex.Message);
        }
    }
}

