public sealed class Singleton
{
    private static readonly Lazy<Singleton> _instance = 
        new Lazy<Singleton>(() => new Singleton());

    // Private constructor to prevent instantiation
    private Singleton() { }

    public static Singleton Instance => _instance.Value;

    public void DisplayMessage()
    {
        Console.WriteLine("Singleton instance method called.");
    }
}

Singleton.Instance.DisplayMessage();
