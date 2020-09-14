using DesignPatterns.Factory.Interface;

namespace DesignPatterns.Factory.Model
{
    public class CardController : IController
    {
        public string OpenDoor() => "Door opened by Card";
    }
}
