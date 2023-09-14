namespace Polymorphism
{
    public interface IAnimal
    {
        string Name { get; set; }
        string GetVoice();

        string GetColor();

        string GetColor(string animalName);
    }
}