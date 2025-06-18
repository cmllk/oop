partial class DessertSv
{
    private DataGridView dgvOrders;
    private RadioButton rbHot1;
    private RadioButton rbDessert1;
    private TextBox txtName;
    private TextBox txtName1;
    private Label lblType2;
    private Label lblType3;
    private Button btnSave;
    private Button btnDelete;
    private Button btnClose;
    private void InitializeComponent()
    {
        this.dgvOrders = new DataGridView();
        this.rbHot1 = new RadioButton();
        this.rbDessert1 = new RadioButton();
        this.txtName = new TextBox();
        this.txtName1 = new TextBox();
        this.lblType2 = new Label();
        this.lblType3 = new Label();
        this.btnSave = new Button();
        this.btnDelete = new Button();
        this.btnClose = new Button();

        this.btnClose.Location = new System.Drawing.Point(1200, 660); 
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(350, 60);
        this.btnClose.TabIndex = 6;
        this.btnClose.Text = "Назад";
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15F);
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
        this.Controls.Add(this.btnClose);

        this.ClientSize = new System.Drawing.Size(1600, 800);

        
        this.dgvOrders.Location = new System.Drawing.Point(20, 20);
        this.dgvOrders.Size = new System.Drawing.Size(950, 600);
        this.dgvOrders.CellEndEdit += new DataGridViewCellEventHandler(this.dgvOrders_CellEndEdit);

        this.rbHot1.Text = "Общие св-ва";
        this.rbHot1.Location = new System.Drawing.Point(1050, 30);
        this.rbHot1.Size = new System.Drawing.Size(300, 70);
        this.rbHot1.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.rbHot1.CheckedChanged += new System.EventHandler(this.rbHot_CheckedChanged1);

        this.rbDessert1.Text = "Собственные св-ва";
        this.rbDessert1.Location = new System.Drawing.Point(1050, 90);
        this.rbDessert1.Size = new System.Drawing.Size(300, 70);
        this.rbDessert1.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.rbDessert1.CheckedChanged += new System.EventHandler(this.rbDessert_CheckedChanged);

        this.lblType2.Text = "Название:";
        this.lblType2.Location = new System.Drawing.Point(1050, 180);
        this.lblType2.Size = new System.Drawing.Size(150, 70);
        this.lblType2.Font = new System.Drawing.Font("Segoe UI", 12F);

        this.lblType3.Text = "Цена:";
        this.lblType3.Location = new System.Drawing.Point(1050, 220);
        this.lblType3.Size = new System.Drawing.Size(150, 70);
        this.lblType3.Font = new System.Drawing.Font("Segoe UI", 12F);

        this.txtName.Location = new System.Drawing.Point(1250, 180);
        this.txtName.Size = new System.Drawing.Size(200, 30);
        this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);

        this.txtName1.Location = new System.Drawing.Point(1250, 220);
        this.txtName1.Size = new System.Drawing.Size(200, 30);
        this.txtName1.Font = new System.Drawing.Font("Segoe UI", 12F);

        this.btnSave.Location = new System.Drawing.Point(1050, 300);
        this.btnSave.Size = new System.Drawing.Size(250, 70);
        this.btnSave.Text = "Добавить";
        this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        this.Controls.Add(this.btnSave);

        this.btnDelete.Location = new System.Drawing.Point(1050, 400);
        this.btnDelete.Size = new System.Drawing.Size(250, 70);
        this.btnDelete.Text = "Удалить";
        this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.dgvOrders);
        this.Controls.Add(this.rbHot1);
        this.Controls.Add(this.rbDessert1);
        this.Controls.Add(this.lblType3);
        this.Controls.Add(this.lblType2);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.txtName1);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.btnDelete);

        this.Text = "Свойства блюда";
    }
}