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
        $"�����������: {Temperature}�C, ����� �������������: {CookTime} �����";

    public override string Pack() =>
        "��������� � �������������.";

    public string Reheat(bool need) =>
        need ? "������� ���������." : "�������� �� ���������.";

    public string AddGarnish(string garnish) =>
        $"� {Name} �������� ������: {garnish}";
}
