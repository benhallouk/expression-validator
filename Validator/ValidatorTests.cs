using ExpressionValidator;
using NUnit.Framework;

namespace ExpressionValidatorTests
{
    public class ValidatorTests
    {
        [Test]
        public void Simple_Expression_Valid()
        {
            Assert.AreEqual(Validator.ValidateExpression("{}"), true);
        }

        [Test]
        public void Simple_Expression_Invalid()
        {
            Assert.AreEqual(Validator.ValidateExpression("{)"), false);
        }

        [Test]
        public void Mirror_Expression_Valid()
        {
            Assert.AreEqual(Validator.ValidateExpression("{}()[]"), true);
        }

        [Test]
        public void Mirror_Expression_Invalid()
        {
            Assert.AreEqual(Validator.ValidateExpression("{}(][]"), false);
        }

        [Test]
        public void Complex_Valid_Expression()
        {
            Assert.AreEqual(Validator.ValidateExpression("[({([{}])})]"), true);
        }

        [Test]
        public void Complex_Valid_Expression_With_Numbers()
        {
            Assert.AreEqual(Validator.ValidateExpression("12[3(4{5(6[7{8}9]10)11}12)13]-4"), true);
        }
    }
}
