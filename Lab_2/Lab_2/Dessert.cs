public class Dessert : Dish
{
    public int SweetnessLevel { get; set; }
    public string Type { get; set; }

    public Dessert(string name, double price, int level, string type)
        : base(name, price)
    {
        SweetnessLevel = level;
        Type = type ?? throw new ArgumentNullException(nameof(type)); 
    }

    public override string Cook() =>
        $"{Name} ({Type}) — уровень сладости: {SweetnessLevel}/10";

    public override string Pack() =>
        "Упаковано в коробку с украшением.";

    public string AddTopping(string topping) =>
        $"Добавлен топпинг: {topping}";

    public string Freeze(bool need) =>
        need ? "Требует охлаждения." : "Охлаждение не требуется.";
}
