using NUnit.Framework;

namespace methode_unit_tests
{
    [TestFixture]
    public class ElfproefTests
    {
        [Test]
        public void GeldigeNummers()
        {
            Assert.That(ElfproefChecker.Elfproef("123456789"), Is.True);
            Assert.That(ElfproefChecker.Elfproef("100000002"), Is.True);
            Assert.That(ElfproefChecker.Elfproef("000000019"), Is.True);
        }

        [Test]
        public void OngeldigeNummers()
        {
            Assert.That(ElfproefChecker.Elfproef("111222333"), Is.False);
            Assert.That(ElfproefChecker.Elfproef("987654321"), Is.False);
        }

        [Test]
        public void NietCijferInput()
        {
            Assert.That(ElfproefChecker.Elfproef("ABC123"), Is.False);
            Assert.That(ElfproefChecker.Elfproef("123 45A"), Is.False);
        }

        [Test]
        public void LegeOfNullInput()
        {
            Assert.That(ElfproefChecker.Elfproef(null), Is.False);
            Assert.That(ElfproefChecker.Elfproef(""), Is.False);
            Assert.That(ElfproefChecker.Elfproef("    "), Is.False);
        }
    }
}
