using System;
using System.Windows.Forms;

public partial class HotDishNas : Form
{
    private Dish selectedDish;

    public HotDishNas()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.FixedSingle; 
        this.MaximizeBox = false; 
        this.MinimizeBox = true;  
        this.StartPosition = FormStartPosition.CenterScreen; 
        this.ClientSize = new System.Drawing.Size(1050, 700);
        LoadDishes();
    }

    private void LoadDishes()
    {
        ComboBoxDishes.Items.Clear();

        Dish dish1 = new HotDish("Пицца", 250.0, 220, 30);
        Dish dish2 = new HotDish("Бургер", 150.0, 180, 15);
        Dish dish3 = new HotDish("Паста", 200.0, 210, 25);

        ComboBoxDishes.Items.Add(dish1);
        ComboBoxDishes.Items.Add(dish2);
        ComboBoxDishes.Items.Add(dish3);

        ComboBoxDishes.SelectedIndex = 0;
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void ComboBoxDishes_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedDish = (Dish)ComboBoxDishes.SelectedItem;
    }

    private void BtnCook_Click(object sender, EventArgs e)
    {
        if (selectedDish != null)
        {
            string cookInfo = selectedDish.Cook();
            AddToHistory($"Приготовление блюда: {selectedDish.Name}\n{cookInfo}");
        }
        else
        {
            MessageBox.Show("Пожалуйста, выберите блюдо.");
        }
    }

    private void BtnPack_Click(object sender, EventArgs e)
    {
        if (selectedDish != null)
        {
            string packInfo = selectedDish.Pack();
            AddToHistory($"Упаковка блюда: {selectedDish.Name}\n{packInfo}");
        }
        else
        {
            MessageBox.Show("Пожалуйста, выберите блюдо.");
        }
    }

    private void AddToHistory(string text)
    {
        // Добавляем текст в конец TextBox
        TxtResult.AppendText(text + Environment.NewLine  + Environment.NewLine);
    }
}
