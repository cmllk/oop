using System;
using System.Windows.Forms;


    
    public partial class HotSob : Form
    {
       
        private HotDish currentDish;

        public HotSob()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(1000, 550);

            currentDish = new HotDish("Котлета по-киевски", 250, 180, 25); 
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    // Метод для добавления гарнира
    private void BtnAddGarnish_Click(object sender, EventArgs e)
        {
            string garnish = txtGarnish.Text.Trim();

            if (string.IsNullOrEmpty(garnish))
            {
                MessageBox.Show("Введите гарнир.");
                return;
            }

            string result = currentDish.AddGarnish(garnish);

            txtHistory.AppendText(result + "\n");
            txtGarnish.Clear(); 
        }

        // Метод для обработки разогрева блюда
        private void BtnServe_Click(object sender, EventArgs e)
        {
            bool shouldReheat = rbReheatYes.Checked;

            string result = currentDish.Reheat(shouldReheat);

            txtHistory.AppendText(result + "\n");
        }
    }

