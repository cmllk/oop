using System;
using System.Windows.Forms;
using System.Xml.Linq;

    public partial class DessertPer : Form
    { 
        public DessertPer()
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
            string selectedDish = cbDishes.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedDish))
            {
            TxtResult.AppendText("Ошибка: выберите блюдо!\n");
                return;
            }

            Dessert dessert;
            switch (selectedDish)
            {
                case "Торт":
                    dessert = new Dessert("Торт", 250, 180, "Десерт");
                    break;
                case "Пирог":
                    dessert = new Dessert("Пирог", 200, 170, "Десерт");
                    break;
                case "Мороженое":
                    dessert = new Dessert("Мороженое", 150, 160, "Десерт");
                    break;
                default:
                TxtResult.AppendText("Ошибка: неизвестное блюдо.\n");
                    return;
            }

            string result = dessert.Serve(rbHot.Checked ? 1 : rbDessert.Checked ? 0 : -1);
        
        TxtResult.AppendText(result + "\n");
        }

        private void BtnCalories_Click(object sender, EventArgs e)
        {
            string selectedDish = cbDishes.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedDish))
            {
            TxtResult.AppendText("Ошибка: выберите блюдо.\n");
                return;
            }

            if (!float.TryParse(txtName.Text, out float weight) || weight <= 0)
            {
            TxtResult.AppendText("Ошибка: введите корректный вес.\n");
                return;
            }

            Dessert dessert;
            switch (selectedDish)
            {
                case "Торт":
                    dessert = new Dessert("Торт", 250, 180, "Десерт");
                    break;
                case "Пирог":
                    dessert = new Dessert("Пирог", 200, 170, "Десерт");
                    break;
                case "Мороженое":
                    dessert = new Dessert("Мороженое", 150, 160, "Десерт");
                    break;
                default:
                    TxtResult.AppendText("Ошибка: неизвестное блюдо.\n");
                    return;
            }

            // Вычисляем калории
            float calories = dessert.Calories(weight);

        TxtResult.AppendText($"Калорийность блюда '{dessert.Name}' весом {weight} г: {calories} ккал\n");
        }
    }
