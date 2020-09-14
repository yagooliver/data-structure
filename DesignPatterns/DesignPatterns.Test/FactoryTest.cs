using DesignPatterns.Factory.Creators;
using DesignPatterns.Factory.Enum;
using DesignPatterns.Factory.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void Should_Get_The_Right_Card_Controller_By_Type()
        {
            ICreator instance = new ConcreteCreator();
            instance.FactoryMethod(Manufacturer.Card);
            var creator = instance.FactoryMethod(Manufacturer.Card);
            var expectedValue = "Door opened by Card";

            Assert.AreEqual(expectedValue, creator.OpenDoor());
        }

        [TestMethod]
        public void Should_Get_The_Right_Biometric_Controller_By_Type()
        {
            ICreator instance = new ConcreteCreator();
            var creator = instance.FactoryMethod(Manufacturer.Biometric);
            var expectedValue = "Door opened by biometric";

            Assert.AreEqual(expectedValue, creator.OpenDoor());
        }

        [TestMethod]
        public void Should_Return_The_Right_Biometric_Instance()
        {
            ICreator instance = new ConcreteCreator();
            instance.FactoryMethod(Manufacturer.Biometric);
            var expectedType = "BiometricController";
            var type = instance.FactoryMethod(Manufacturer.Biometric).GetType().Name;

            Assert.AreEqual(expectedType, type);
        }
        [TestMethod]
        public void Should_Return_The_Right_Card_Instance()
        {
            ICreator instance = new ConcreteCreator();
            var expectedType = "CardController";
            var type = instance.FactoryMethod(Manufacturer.Card).GetType().Name;

            Assert.AreEqual(expectedType, type);
        }
    }
}
