
using System;
using System.Windows.Forms;
using Npgsql;
using System.Data;

public partial class HotPer : Form
{
    public HotPer()
    {
        InitializeComponent();

        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = true;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.ClientSize = new System.Drawing.Size(2050, 650);

    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void BtnServe_Click(object sender, EventArgs e)
    {
        int where = rbHot.Checked ? 1 : rbDessert.Checked ? 0 : -1;

        if (where == -1)
        {
            MessageBox.Show("Выберите способ подачи!");
            return;
        }

        string selectedDish = cbDishes.SelectedItem?.ToString();

        if (string.IsNullOrEmpty(selectedDish))
        {
            MessageBox.Show("Выберите блюдо!");
            return;
        }

        HotDish dish;
        switch (selectedDish)
        {
            case "Котлета по-киевски":
                dish = new HotDish("Котлета по-киевски", 250, 180, 25);
                break;
            case "Плов":
                dish = new HotDish("Плов", 300, 200, 30);
                break;
            case "Лазанья":
                dish = new HotDish("Лазанья", 270, 190, 28);
                break;
            default:
                MessageBox.Show("Неизвестное блюдо.");
                return;
        }

        string result = dish.Serve(where);
        MessageBox.Show(result, "Результат подачи");
    }

    private void BtnCalories_Click(object sender, EventArgs e)
    {
        string selectedDish = cbDishes.SelectedItem?.ToString();
        if (string.IsNullOrEmpty(selectedDish))
        {
            MessageBox.Show("Выберите блюдо.");
            return;
        }

        if (!float.TryParse(txtName.Text, out float weight) || weight <= 0)
        {
            MessageBox.Show("Введите корректный вес.");
            return;
        }
        HotDish dish;
        switch (selectedDish)
        {
            case "Котлета по-киевски":
                dish = new HotDish("Котлета по-киевски", 250, 180, 25);
                break;
            case "Плов":
                dish = new HotDish("Плов", 300, 200, 30);
                break;
            case "Лазанья":
                dish = new HotDish("Лазанья", 270, 190, 28);
                break;
            default:
                MessageBox.Show("Неизвестное блюдо.");
                return;
        }

        float calories = dish.Calories(weight);
        MessageBox.Show($"Калорийность блюда '{dish.Name}' весом {weight} г: {calories} ккал", "Результат");
    }



}
