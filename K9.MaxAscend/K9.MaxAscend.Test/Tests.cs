using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9.MaxAscend.Test
{
    [TestFixture]
    public class Tests
    {
        /* Test case 1 */
        [Test]
        public string TestFindBiggestSortedSublist(string input)
        {
            return MaxAscend.Main(input);
        }
    }
}
