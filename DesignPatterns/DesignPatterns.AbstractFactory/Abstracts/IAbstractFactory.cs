using DesignPatterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Abstracts
{
    public interface IAbstractFactory
    {
        IBiometricController CreateBiometric();
        ICardController CreateCard();
    }
}
