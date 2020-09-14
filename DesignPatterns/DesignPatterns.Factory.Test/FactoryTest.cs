using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Factory.Test
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void Should_Get_The_Right_Card_Controller_By_Type()
        {
            var instance = new Creators.ConcreteCreator();
            instance.FactoryMethod(Enum.Manufacturer.Card);
            var creator = instance.FactoryMethod(Enum.Manufacturer.Card);
            var expectedValue = "Door opened by Card";

            Assert.AreEqual(expectedValue, creator.OpenDoor());
        }

        [TestMethod]
        public void Should_Get_The_Right_Biometric_Controller_By_Type()
        {
            var instance = new Creators.ConcreteCreator();
            var creator = instance.FactoryMethod(Enum.Manufacturer.Biometric);
            var expectedValue = "Door opened by biometric";

            Assert.AreEqual(expectedValue, creator.OpenDoor());
        }

        [TestMethod]
        public void Should_Return_The_Right_Biometric_Instance()
        {
            var instance = new Creators.ConcreteCreator();
            instance.FactoryMethod(Enum.Manufacturer.Biometric);
            var expectedType = "BiometricController";
            var type = instance.FactoryMethod(Enum.Manufacturer.Biometric).GetType().Name;

            Assert.AreEqual(expectedType, type);
        }
        [TestMethod]
        public void Should_Return_The_Right_Card_Instance()
        {
            var instance = new Creators.ConcreteCreator();
            var expectedType = "CardController";
            var type = instance.FactoryMethod(Enum.Manufacturer.Card).GetType().Name;

            Assert.AreEqual(expectedType, type);
        }
    }
}
