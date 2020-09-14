namespace DesignPatterns.AbstractFactory.Models
{
    public class BiometricController : IBiometricController
    {
        public bool IsDuressFinger()
        {
            return true;
        }

        public string OpenDoor() => "Door opened by biometric";
    }
}
