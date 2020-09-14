namespace DesignPatterns.AbstractFactory.Models
{
    public class CardController : ICardController
    {
        public string OpenDoor() => "Door opened by Card";
    }
}
