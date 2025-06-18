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
        $"{Name} ({Type}) � ������� ��������: {SweetnessLevel}/10";

    public override string Pack() =>
        "��������� � ������� � ����������.";

    public string AddTopping(string topping) =>
        $"�������� �������: {topping}";

    public string Freeze(bool need) =>
        need ? "������� ����������." : "���������� �� ���������.";
}
