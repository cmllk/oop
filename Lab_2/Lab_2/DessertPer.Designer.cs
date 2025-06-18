partial class DessertPer
{
    private System.Windows.Forms.TextBox TxtResult;
private System.Windows.Forms.ComboBox cbDishes;
private System.Windows.Forms.RadioButton rbHot;
private System.Windows.Forms.RadioButton rbDessert;
private System.Windows.Forms.Label lblType1;
private System.Windows.Forms.Label lblType;
private System.Windows.Forms.Label lblType2;
private System.Windows.Forms.Label lblType3;
private System.Windows.Forms.TextBox txtName;
private System.Windows.Forms.Button btnSave;
private System.Windows.Forms.Button btnSave1;
private System.Windows.Forms.Button btnClose;

    private void InitializeComponent()
{
    this.rbHot = new System.Windows.Forms.RadioButton();
    this.rbDessert = new System.Windows.Forms.RadioButton();
    this.lblType = new System.Windows.Forms.Label();
    this.lblType1 = new System.Windows.Forms.Label();
    this.lblType2 = new System.Windows.Forms.Label();
    this.lblType3 = new System.Windows.Forms.Label();
    this.txtName = new System.Windows.Forms.TextBox();
    this.cbDishes = new System.Windows.Forms.ComboBox();
    this.btnSave = new System.Windows.Forms.Button();
    this.btnSave1 = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.TxtResult = new System.Windows.Forms.TextBox(); 

    this.SuspendLayout();

        this.btnClose.Location = new System.Drawing.Point(1400, 450); 
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(350, 60);
        this.btnClose.TabIndex = 6;
        this.btnClose.Text = "Назад";
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15F);
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
        this.Controls.Add(this.btnClose);


        this.btnSave.Location = new System.Drawing.Point(250, 320);
    this.btnSave.Size = new System.Drawing.Size(400, 70);
    this.btnSave.Text = "Подать";
    this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15F);
    this.btnSave.Click += new System.EventHandler(this.BtnServe_Click);
    this.Controls.Add(this.btnSave);

    this.btnSave1.Location = new System.Drawing.Point(1100, 320);
    this.btnSave1.Size = new System.Drawing.Size(400, 70);
    this.btnSave1.Text = "Рассчитать";
    this.btnSave1.Font = new System.Drawing.Font("Segoe UI", 15F);
    this.btnSave1.Click += new System.EventHandler(this.BtnCalories_Click);
    this.Controls.Add(this.btnSave1);

    this.rbHot.AutoSize = true;
    this.rbHot.Location = new System.Drawing.Point(300, 90);
    this.rbHot.Name = "rbHot";
    this.rbHot.Size = new System.Drawing.Size(300, 40);
    this.rbHot.TabIndex = 0;
    this.rbHot.TabStop = true;
    this.rbHot.Text = "С собой";
    this.rbHot.Font = new System.Drawing.Font("Segoe UI", 15F);

    this.rbDessert.AutoSize = true;
    this.rbDessert.Location = new System.Drawing.Point(300, 150);
    this.rbDessert.Name = "rbDessert";
    this.rbDessert.Size = new System.Drawing.Size(300, 40);
    this.rbDessert.TabIndex = 1;
    this.rbDessert.TabStop = true;
    this.rbDessert.Text = "В зале";
    this.rbDessert.Font = new System.Drawing.Font("Segoe UI", 15F);

    this.lblType.AutoSize = true;
    this.lblType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
    this.lblType.Location = new System.Drawing.Point(150, 30);
    this.lblType.Text = "Выберите способ подачи:";
    this.Controls.Add(this.lblType);

        this.lblType3.AutoSize = true;
        this.lblType3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblType3.Location = new System.Drawing.Point(850, 30);
        this.lblType3.Text = "Рассчитать каллорийность:";
        this.Controls.Add(this.lblType3);

        this.lblType1.AutoSize = true;
    this.lblType1.Font = new System.Drawing.Font("Segoe UI", 15F);
    this.lblType1.Location = new System.Drawing.Point(410, 230);
    this.lblType1.Text = "Выберите Блюдо:";
    this.Controls.Add(this.lblType1);

    this.lblType2.AutoSize = true;
    this.lblType2.Font = new System.Drawing.Font("Segoe UI", 15F);
    this.lblType2.Location = new System.Drawing.Point(900, 100);
    this.lblType2.Text = "Введите вес блюда(г):";
    this.Controls.Add(this.lblType2);

    this.txtName.Location = new System.Drawing.Point(1300, 100);
    this.txtName.Name = "txtName";
    this.txtName.Size = new System.Drawing.Size(100, 100);
    this.txtName.Font = new System.Drawing.Font("Segoe UI", 15F);
    this.Controls.Add(this.txtName);

    this.cbDishes.AutoSize = true;
    this.cbDishes.Font = new System.Drawing.Font("Segoe UI", 15F);
    this.cbDishes.Location = new System.Drawing.Point(750, 230);
    this.cbDishes.Size = new System.Drawing.Size(300, 40);
    this.cbDishes.Items.Add("Торт");
    this.cbDishes.Items.Add("Пирог");
    this.cbDishes.Items.Add("Мороженное");
    this.cbDishes.SelectedIndex = 0;
    this.Controls.Add(this.cbDishes);
         
    this.TxtResult.Location = new System.Drawing.Point(600, 450);
    this.TxtResult.Multiline = true;
    this.TxtResult.Name = "TxtResult";
    this.TxtResult.ReadOnly = true;
    this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
    this.TxtResult.Size = new System.Drawing.Size(800, 200);
    this.TxtResult.Font = new System.Drawing.Font("Segoe UI", 12F);
    this.Controls.Add(this.TxtResult); 

    this.Controls.Add(this.rbHot);
    this.Controls.Add(this.rbDessert);
    this.Controls.Add(this.lblType);
    this.Controls.Add(this.lblType1);
    this.Controls.Add(this.lblType2);
    this.Controls.Add(this.lblType3);
    this.Controls.Add(this.btnSave);
    this.Controls.Add(this.btnSave1);

    this.ResumeLayout(false);
}

}
