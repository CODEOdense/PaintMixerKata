using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    [TestFixture]
    class ColorValueTests
    {
        [Test]
        public void ColorValueIsAlways0to255()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new ColorValue(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new ColorValue(256));
            Assert.DoesNotThrow(() => new ColorValue(0));
            Assert.DoesNotThrow(() => new ColorValue(255));
        }
    }
}
