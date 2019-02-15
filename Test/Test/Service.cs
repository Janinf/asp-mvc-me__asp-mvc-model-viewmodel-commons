namespace Test
{
    public class Service : IService
    {
        public string GetGreeting(string name, string greeting) => $"{greeting} {name}";

        public string GetGreeting(string name) => GetGreeting(name, "Hello");

        public string GetGreeting() => GetGreeting("World", "Hello");
    }
}
