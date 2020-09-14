using DesignPatterns.AbstractFactory.Abstracts;
using DesignPatterns.AbstractFactory.Models;

namespace DesignPatterns.AbstractFactory.Concrete
{
    public class ConcreteCreators : IAbstractFactory
    {
        public IBiometricController CreateBiometric() => new BiometricController();

        public ICardController CreateCard() => new CardController();
    }
}
