partial class HotSv
{
    private System.Windows.Forms.DataGridView dgvOrders;
    private System.Windows.Forms.RadioButton rbHot;
    private System.Windows.Forms.RadioButton rbDessert;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtName1;
    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.Label lblType1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnSave1;
    private System.Windows.Forms.Button btnClose;
    private void InitializeComponent()
    {
        this.rbHot = new System.Windows.Forms.RadioButton();
        this.rbDessert = new System.Windows.Forms.RadioButton();
        this.txtName = new System.Windows.Forms.TextBox();
        this.txtName1 = new System.Windows.Forms.TextBox();
        this.lblType = new System.Windows.Forms.Label();
        this.lblType1 = new System.Windows.Forms.Label();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnSave1 = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.SuspendLayout();

        this.btnClose.Location = new System.Drawing.Point(1200, 660); 
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(350, 60);
        this.btnClose.TabIndex = 6;
        this.btnClose.Text = "Назад";
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15F);
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
        this.Controls.Add(this.btnClose);

        this.btnSave.Location = new System.Drawing.Point(1100, 300);
        this.btnSave.Size = new System.Drawing.Size(250, 70);
        this.btnSave.Text = "Добавить";
        this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        this.Controls.Add(this.btnSave);

        this.btnSave1.Location = new System.Drawing.Point(1100, 400);
        this.btnSave1.Size = new System.Drawing.Size(250, 70);
        this.btnSave1.Text = "Удалить";
        this.btnSave1.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.btnSave1.Click += new System.EventHandler(this.btnDelete_Click);
        this.Controls.Add(this.btnSave1);

        this.rbHot.AutoSize = true;
        this.rbHot.Location = new System.Drawing.Point(1100, 30);
        this.rbHot.Name = "rbHot";
        this.rbHot.Size = new System.Drawing.Size(300, 40);
        this.rbHot.TabIndex = 0;
        this.rbHot.TabStop = true;
        this.rbHot.Text = "Общие св-ва";
        this.rbHot.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.rbHot.CheckedChanged += new System.EventHandler(this.rbHot_CheckedChanged);

        this.rbDessert.AutoSize = true;
        this.rbDessert.Location = new System.Drawing.Point(1100, 80);
        this.rbDessert.Name = "rbDessert";
        this.rbDessert.Size = new System.Drawing.Size(300, 40);
        this.rbDessert.TabIndex = 1;
        this.rbDessert.TabStop = true;
        this.rbDessert.Text = "Собственные св-ва";
        this.rbDessert.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.rbDessert.CheckedChanged += new System.EventHandler(this.rbDessert_CheckedChanged);

       
        this.txtName.Location = new System.Drawing.Point(1250, 200);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(200, 20);

        this.txtName1.Location = new System.Drawing.Point(1250, 250);
        this.txtName1.Name = "txtName";
        this.txtName1.Size = new System.Drawing.Size(200, 20);

        this.lblType.AutoSize = true;
        this.lblType.Location = new System.Drawing.Point(1100, 200);
        this.lblType.Name = "lblType";
        this.lblType.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblType.Size = new System.Drawing.Size(122, 13);
        this.lblType.TabIndex = 3;

        this.lblType1.AutoSize = true;
        this.lblType1.Location = new System.Drawing.Point(1100, 250);
        this.lblType1.Name = "lblType1";
        this.lblType1.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblType1.Size = new System.Drawing.Size(122, 13);
        this.lblType1.TabIndex = 3;

        this.Controls.Add(this.rbHot);
        this.Controls.Add(this.rbDessert);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.txtName1);
        this.Controls.Add(this.lblType);
        this.Controls.Add(this.lblType1);
        this.Controls.Add(this.btnSave);

        this.dgvOrders = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
        this.SuspendLayout();

        this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvOrders.Location = new System.Drawing.Point(20, 20);
        this.dgvOrders.Name = "dgvOrders";
        this.dgvOrders.Size = new System.Drawing.Size(650, 300);
        this.dgvOrders.TabIndex = 0;
        this.dgvOrders.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellEndEdit);


        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.dgvOrders);
        this.Name = "HotSv";
        this.Text = "Общие/Собственные Горячего блюда";
        this.ResumeLayout(false);

        ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();


    }
}
