using DesignPatterns.Factory.Enum;
using DesignPatterns.Factory.Interface;
using DesignPatterns.Factory.Model;

namespace DesignPatterns.Factory.Creators
{
    public class ConcreteCreator : ICreator
    {
        public IController FactoryMethod(Manufacturer manufacturer)
        {
            switch (manufacturer)
            {
                case Manufacturer.Biometric:
                    return new BiometricController();
                case Manufacturer.Card:
                    return new CardController();
                default:
                    return null;
            }
        }
    }
}
