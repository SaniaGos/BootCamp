namespace Polymorphism
{
    public interface IAnimalBase
    {
        string Name { get; set; }
    }
    public interface IAnimal : IAnimalBase
    {
        string GetVoice();
        void GetVoice(uint count);
        void GetVoice(string addCommand);
        void GoPlay();
    }
}