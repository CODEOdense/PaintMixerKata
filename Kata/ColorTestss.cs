using NUnit.Framework;
using Ploeh.AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    [TestFixture]
    class ColorTestss
    {
        [Test]
        public void ColorEquality()
        {
            var a = new Color(20, 10, 30);
            var b = new Color(20, 10, 30);

            Assert.AreEqual(a, b);
        }

        [Test]
        public void MixItGood()
        {
            var expected = new Color(40, 40, 0);
            var a = new Color(80, 0, 0);
            var b = new Color(0, 80, 0);

            Assert.That(a+b, Is.EqualTo(expected));
        }
    }
}
