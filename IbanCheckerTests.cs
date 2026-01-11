using NUnit.Framework;

namespace methode_unit_tests
{
    [TestFixture]
    public class IbanCheckerTests
    {
        [Test]
        public void GeldigeIbans()
        {
            Assert.That(IbanChecker.IsGeldigIban("NL91ABNA0417164300"), Is.True);
            Assert.That(IbanChecker.IsGeldigIban("NL20INGB0001234567"), Is.True);
            Assert.That(IbanChecker.IsGeldigIban("DE89370400440532013000"), Is.True);
            Assert.That(IbanChecker.IsGeldigIban("GB82WEST12345698765432"), Is.True);
        }

        [Test]
        public void OngeldigeIbans()
        {
            Assert.That(IbanChecker.IsGeldigIban("NL91ABNA0417164301"), Is.False);
            Assert.That(IbanChecker.IsGeldigIban("NL00ABNA0417164300"), Is.False);
            Assert.That(IbanChecker.IsGeldigIban("DE89370400440532013001"), Is.False);
        }

        [Test]
        public void NietGeldigeTekens()
        {
            Assert.That(IbanChecker.IsGeldigIban("NL91ABNA04171@4300"), Is.False);
            Assert.That(IbanChecker.IsGeldigIban("NL91 ABNA 0417 1643 00!"), Is.False);
        }

        [Test]
        public void LegeOfNullInput()
        {
            Assert.That(IbanChecker.IsGeldigIban(null), Is.False);
            Assert.That(IbanChecker.IsGeldigIban(""), Is.False);
            Assert.That(IbanChecker.IsGeldigIban("   "), Is.False);
        }

        [Test]
        public void OnjuisteLengte()
        {
            Assert.That(IbanChecker.IsGeldigIban("NL91ABNA"), Is.False);
            Assert.That(IbanChecker.IsGeldigIban("NL91ABNA041716430012345678901234567"), Is.False);
        }
    }
}
