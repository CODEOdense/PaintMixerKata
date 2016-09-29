using NUnit.Framework;

namespace Kata
{
    [TestFixture]
    public class PaintTests
    {
        [Test]
        public void PaintingEquality()
        {
            var a = new Paint(new Color(20, 10, 30), 100);
            var b = new Paint(new Color(20, 10, 30), 100);

            Assert.AreEqual(a, b);
        }

        [Test]
        public void MixingPaintsDistributesColorValuesAccorrdingToVolume()
        {
            var red = new Paint(new Color(200,0,0), 100);
            var blue = new Paint(new Color(0,0,200), 200);
            var expected = new Paint(new Color(66, 0, 133), 300);

            Assert.That(red + blue, Is.EqualTo(expected));
        }
    }
}
