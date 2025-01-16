// Product Interface
public interface IProduct
{
    void Operate();
}

// Concrete Products
public class ProductA : IProduct
{
    public void Operate() => Console.WriteLine("ProductA is operating.");
}

public class ProductB : IProduct
{
    public void Operate() => Console.WriteLine("ProductB is operating.");
}

// Factory Class
public abstract class ProductFactory
{
    public abstract IProduct CreateProduct();
}

public class ProductAFactory : ProductFactory
{
    public override IProduct CreateProduct() => new ProductA();
}

public class ProductBFactory : ProductFactory
{
    public override IProduct CreateProduct() => new ProductB();
}

ProductFactory factory = new ProductAFactory();
IProduct product = factory.CreateProduct();
product.Operate(); // Output: "ProductA is operating."
