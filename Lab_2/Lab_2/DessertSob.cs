
using System;
using System.Windows.Forms;
using Npgsql;
using System.Data;

public partial class DessertSob : Form
{
    private Dessert currentDessert;

    public DessertSob()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = true;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.ClientSize = new System.Drawing.Size(1000, 550);

        currentDessert = new Dessert("Шоколадный торт", 150, 8, "Торт");

        cmbToppings.Items.Add("Шоколадный сироп");
        cmbToppings.Items.Add("Ванильный крем");
        cmbToppings.Items.Add("Ягоды");
        cmbToppings.Items.Add("Орехи");
        cmbToppings.Items.Add("Карамель");

        cmbToppings.SelectedIndex = 0;
    }
    private void BtnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void BtnAddGarnish_Click(object sender, EventArgs e)
    {
        string topping = cmbToppings.SelectedItem.ToString();

        string result = currentDessert.AddTopping(topping);
        UpdateHistory(result);
    }

    private void BtnServe_Click(object sender, EventArgs e)
    {
        if (currentDessert == null)
        {
            MessageBox.Show("Сначала создайте десерт!");
            return;
        }

        string freezeResult = rbReheatYes.Checked
            ? currentDessert.Freeze(true)
            : currentDessert.Freeze(false);

        UpdateHistory(freezeResult);
    }

    private void UpdateHistory(string message)
    {
        txtHistory.AppendText(message + Environment.NewLine);
    }
}
