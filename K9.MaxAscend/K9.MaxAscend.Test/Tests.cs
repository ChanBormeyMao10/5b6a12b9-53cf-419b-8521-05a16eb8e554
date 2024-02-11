using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace K9.MaxAscend.Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        [TestCaseSource(typeof(FactoryClass), "TestCases")]
        public string TestFindBiggestSortedSublist(string input)
        {
            return MaxAscend.Main(input);
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}
