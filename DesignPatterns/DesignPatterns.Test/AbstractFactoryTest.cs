using DesignPatterns.AbstractFactory.Abstracts;
using DesignPatterns.AbstractFactory.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Test
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void Should_Get_The_Right_Card_Controller_By_Type()
        {
            IAbstractFactory instance = new ConcreteCreators();
            var creator = instance.CreateCard();
            var expectedValue = "Door opened by Card";

            Assert.AreEqual(expectedValue, creator.OpenDoor());
        }

        [TestMethod]
        public void Should_Get_The_Right_Biometric_Controller_By_Type()
        {
            IAbstractFactory instance = new ConcreteCreators();
            var creator = instance.CreateBiometric();
            var expectedValue = "Door opened by biometric";

            Assert.AreEqual(expectedValue, creator.OpenDoor());
        }

        [TestMethod]
        public void Should_Biometric_Have_Duress_Finger()
        {
            IAbstractFactory instance = new ConcreteCreators();
            var creator = instance.CreateBiometric();

            Assert.IsTrue(creator.IsDuressFinger());
        }

        [TestMethod]
        public void Should_Return_The_Right_Biometric_Instance()
        {
            IAbstractFactory instance = new ConcreteCreators();
            var expectedType = "BiometricController";
            var type = instance.CreateBiometric().GetType().Name;

            Assert.AreEqual(expectedType, type);
        }
        [TestMethod]
        public void Should_Return_The_Right_Card_Instance()
        {
            IAbstractFactory instance = new ConcreteCreators();
            var expectedType = "CardController";
            var type = instance.CreateCard().GetType().Name;

            Assert.AreEqual(expectedType, type);
        }

        [TestMethod]
        public void Return_A_Family_of_Instances()
        {
            IAbstractFactory instance = new ConcreteCreators();
            var card = "CardController";
            var biometric = "BiometricController";
            var type = instance.CreateCard().GetType().Name;
            var type2 = instance.CreateBiometric().GetType().Name;

            Assert.AreEqual(card, type);
            Assert.AreEqual(biometric, type2);
        }
    }
}
