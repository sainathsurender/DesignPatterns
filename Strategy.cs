// Strategy Interface
public interface ICompressionStrategy
{
    void Compress(string fileName);
}

// Concrete Strategies
public class ZipCompression : ICompressionStrategy
{
    public void Compress(string fileName) =>
        Console.WriteLine($"Compressing {fileName} using ZIP.");
}

public class RarCompression : ICompressionStrategy
{
    public void Compress(string fileName) =>
        Console.WriteLine($"Compressing {fileName} using RAR.");
}

// Context
public class CompressionContext
{
    private ICompressionStrategy _strategy;

    public void SetStrategy(ICompressionStrategy strategy)
    {
        _strategy = strategy;
    }

    public void CompressFile(string fileName)
    {
        _strategy?.Compress(fileName);
    }
}

CompressionContext context = new CompressionContext();

context.SetStrategy(new ZipCompression());
context.CompressFile("example.txt"); // Output: "Compressing example.txt using ZIP."

context.SetStrategy(new RarCompression());
context.CompressFile("example.txt"); // Output: "Compressing example.txt using RAR."
