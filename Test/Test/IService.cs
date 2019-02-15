namespace Test
{
    interface IService
    {
        string GetGreeting(string name, string greeting);

        string GetGreeting(string name);

        string GetGreeting();
    }
}
