using DesignPatterns.Factory.Enum;

namespace DesignPatterns.Factory.Interface
{
    public interface ICreator
    {
        IController FactoryMethod(Manufacturer manufacturer);
        //string OpenDoor();
    }
}
