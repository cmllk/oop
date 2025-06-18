public abstract class Dish
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Dish(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract string Cook();
    public abstract string Pack();

    public virtual string Serve(int where)
    {
        return where == 0 ? "Подано в зале." : "Подано с собой.";
    }

    public float Calories(float weight)
    {
        return (weight / 10) * 23000;
    }

    public override string ToString()
    {
        return Name;
    }
}
