namespace DesignPatterns.AbstractFactory.Models
{
    public interface IBiometricController
    {
        string OpenDoor();
        bool IsDuressFinger();
    }
}