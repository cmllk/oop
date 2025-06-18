partial class Main
{
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnHotDish;
    private System.Windows.Forms.Button btnDessert;
    private System.Windows.Forms.Button btnSave;
    //private System.Windows.Forms.DataGridView dgvOrders;
    private void InitializeComponent()
    {
        this.lblTitle = new System.Windows.Forms.Label();
        this.btnHotDish = new System.Windows.Forms.Button();
        this.btnDessert = new System.Windows.Forms.Button();
        
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(350, 150);
        this.lblTitle.Text = "Выбор блюда";

        // 
        // btnHotDish
        // 
        this.btnHotDish.Location = new System.Drawing.Point(350, 270);
        this.btnHotDish.Size = new System.Drawing.Size(350, 70);
        this.btnHotDish.Text = "Горячее";
        this.btnHotDish.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.btnHotDish.Click += new System.EventHandler(this.btnOpenForm3_Click);
        this.Controls.Add(this.btnHotDish);

        this.btnDessert.Location = new System.Drawing.Point(350, 370);
        this.btnDessert.Size = new System.Drawing.Size(350, 70);
        this.btnDessert.Text = "Десерт";
        this.btnDessert.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.btnDessert.Click += new System.EventHandler(this.btnOpenForm2_Click);

        this.ClientSize = new System.Drawing.Size(600, 400);
        this.Controls.Add(this.lblTitle);
        this.Controls.Add(this.btnHotDish);
        this.Controls.Add(this.btnDessert);
        //this.Controls.Add(this.dgvOrders);
        this.Text = "Оформление заказа";

    }
}
