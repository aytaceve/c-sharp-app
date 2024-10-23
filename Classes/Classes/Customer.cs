namespace Classes;

public class Customer
{
    public string Name;
    public int Id;
    public readonly List<Order> Orders = new List<Order>();
    public Customer(int id)
    {
        this.Id = id;
    }

    public Customer(int id, string name)
        : this(id)
    {
        this.Name = name;
    }

    public void Introduce(string to)
    {
        Console.WriteLine("Hey {0}! Men {1}am", to, Name);
    }

    public void Promote()
    {
        // Orders = new List<Order>();
    }
} 