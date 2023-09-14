namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var child = new Child();

            child.Speak();
            child.Speak("Hello from overridden Speak(string)");
        }
    }
}