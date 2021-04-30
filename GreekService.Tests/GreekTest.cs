using NUnit.Framework;

namespace GreekService.Tests {

    [TestFixture]
    public class Tests {

        private GreekService _greekService;

        [SetUp]
        public void Setup() {
            _greekService = new GreekService();
        }

        [Test]
        public void GreetShouldBeHello() {
            var result = _greekService.Greet("Hola");
            Assert.AreEqual("Hello, Hola", result);
        }

        [Test]
        public void GreetShoulBeMyFriend() {
            var result = _greekService.Greet(null);
            Assert.AreEqual("Hello, my friend.", result);
        }

        [Test]
        public void GreetShoulBeUpperCase() {
            var name = "JERRY";
            var result = _greekService.IsAllUpperCase(name);
            Assert.IsTrue(result);
        }

        [Test]
        public void GreetShoulBeJERRY() {
            var name = "JOHN";
            var result = _greekService.Greet(name);
            Assert.AreEqual(result, "HELLO JOHN!");
        }
    }
}