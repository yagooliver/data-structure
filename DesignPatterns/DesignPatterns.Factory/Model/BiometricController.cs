using DesignPatterns.Factory.Interface;

namespace DesignPatterns.Factory.Model
{
    public class BiometricController : IController
    {
        public string OpenDoor() => "Door opened by biometric";
    }
}
