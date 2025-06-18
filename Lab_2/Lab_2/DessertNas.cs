using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class DessertNas : Form
{
    private List<Dessert> desserts;
    private Dessert selectedDessert;

    public DessertNas()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.FixedSingle; 
        this.MaximizeBox = false;
        this.MinimizeBox = true;  
        this.StartPosition = FormStartPosition.CenterScreen; 
        this.ClientSize = new System.Drawing.Size(1050, 700);
        InitializeDesserts();
    }

    private void InitializeDesserts()
    {
        desserts = new List<Dessert>
        {
            new Dessert("Торт", 200, 8, "Шоколадный"),
            new Dessert("Мороженое", 100, 5, "Ванильное"),
            new Dessert("Крем-брюле", 150, 7, "Французский")
        };

        ComboBoxDishes.Items.Clear();
        foreach (var dessert in desserts)
        {
            ComboBoxDishes.Items.Add(dessert.Name);
        }

        ComboBoxDishes.SelectedIndex = 0; 
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void ComboBoxDishes_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedDessert = desserts[ComboBoxDishes.SelectedIndex];
    }

    private void BtnCook_Click(object sender, EventArgs e)
    {
        if (selectedDessert != null)
        {
            string cookResult = selectedDessert.Cook();
            TxtResult.Text += $"{DateTime.Now}: {cookResult}\r\n"; 
        }
        else
        {
            MessageBox.Show("Выберите десерт!");
        }
    }

    private void BtnPack_Click(object sender, EventArgs e)
    {
        if (selectedDessert != null)
        {
            string packResult = selectedDessert.Pack();
            TxtResult.Text += $"{DateTime.Now}: {packResult}\r\n";  
        }
        else
        {
            MessageBox.Show("Выберите десерт!");
        }
    }
}
