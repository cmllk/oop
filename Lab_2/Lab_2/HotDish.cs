public class HotDish : Dish
{
    public int Temperature { get; set; }
    public int CookTime { get; set; }

    public HotDish(string name, double price, int temp, int time)
        : base(name, price)
    {
        Temperature = temp;
        CookTime = time;
    }

    public override string Cook() =>
        $"Температура: {Temperature}°C, Время приготовления: {CookTime} минут";

    public override string Pack() =>
        "Упаковано в термоупаковку.";

    public string Reheat(bool need) =>
        need ? "Требует разогрева." : "Разогрев не требуется.";

    public string AddGarnish(string garnish) =>
        $"К {Name} добавлен гарнир: {garnish}";
}
