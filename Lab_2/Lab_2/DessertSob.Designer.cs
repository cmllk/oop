partial class DessertSob
{
    private System.Windows.Forms.RadioButton rbReheatYes;
    private System.Windows.Forms.RadioButton rbReheatNo;
    private System.Windows.Forms.TextBox txtHistory;
    private System.Windows.Forms.TextBox txtGarnish;
    private System.Windows.Forms.Button btnAddGarnish;
    private System.Windows.Forms.ComboBox cmbToppings;
    private System.Windows.Forms.Button btnServe;
    private System.Windows.Forms.Label lblType2;
    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.Button btnClose;

    private void InitializeComponent()
    {
        this.btnAddGarnish = new System.Windows.Forms.Button();
        this.txtHistory = new System.Windows.Forms.TextBox();
        this.lblType = new System.Windows.Forms.Label();
        this.lblType2 = new System.Windows.Forms.Label();
        this.rbReheatYes = new System.Windows.Forms.RadioButton();
        this.rbReheatNo = new System.Windows.Forms.RadioButton();
        this.btnServe = new System.Windows.Forms.Button();
        this.cmbToppings = new System.Windows.Forms.ComboBox();
        this.btnClose = new System.Windows.Forms.Button();
        this.SuspendLayout();


        this.btnClose.Location = new System.Drawing.Point(600, 450); 
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(350, 60);
        this.btnClose.TabIndex = 6;
        this.btnClose.Text = "Назад";
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15F);
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
        this.Controls.Add(this.btnClose);

        this.lblType2.AutoSize = true;
        this.lblType2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblType2.Location = new System.Drawing.Point(20, 30);
        this.lblType2.Text = "Введите топпинг:";
        this.Controls.Add(this.lblType2);

        this.lblType.AutoSize = true;
        this.lblType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblType.Location = new System.Drawing.Point(20, 240);
        this.lblType.Text = "Введите охлаждение:";
        this.Controls.Add(this.lblType);


        this.cmbToppings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbToppings.Font = new System.Drawing.Font("Segoe UI", 15F);
        this.cmbToppings.FormattingEnabled = true;
        this.cmbToppings.Location = new System.Drawing.Point(30, 100);
        this.cmbToppings.Name = "cmbToppings";
        this.cmbToppings.Size = new System.Drawing.Size(400, 36);
        this.cmbToppings.TabIndex = 0;
        this.Controls.Add(this.cmbToppings);
        
        this.btnAddGarnish.Location = new System.Drawing.Point(50, 180);
        this.btnAddGarnish.Name = "btnAddGarnish";
        this.btnAddGarnish.Size = new System.Drawing.Size(350, 60);
        this.btnAddGarnish.TabIndex = 1;
        this.btnAddGarnish.Text = "Добавить топпинг";
        this.btnAddGarnish.Font = new System.Drawing.Font("Segoe UI", 15F);
        this.btnAddGarnish.UseVisualStyleBackColor = true;
        this.btnAddGarnish.Click += new System.EventHandler(this.BtnAddGarnish_Click);
        
        this.txtHistory.Location = new System.Drawing.Point(600, 30);
        this.txtHistory.Multiline = true;
        this.txtHistory.Name = "txtHistory";
        this.txtHistory.ReadOnly = true;
        this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtHistory.Size = new System.Drawing.Size(350, 400);
        this.txtHistory.TabIndex = 2;
        
        this.rbReheatYes.AutoSize = true;
        this.rbReheatYes.Location = new System.Drawing.Point(20, 300);
        this.rbReheatYes.Name = "rbReheatYes";
        this.rbReheatYes.Size = new System.Drawing.Size(104, 21);
        this.rbReheatYes.TabIndex = 3;
        this.rbReheatYes.Font = new System.Drawing.Font("Segoe UI", 15F);
        this.rbReheatYes.TabStop = true;
        this.rbReheatYes.Text = "Охладить";
        this.rbReheatYes.UseVisualStyleBackColor = true;
        
        this.rbReheatNo.AutoSize = true;
        this.rbReheatNo.Location = new System.Drawing.Point(20, 350);
        this.rbReheatNo.Name = "rbReheatNo";
        this.rbReheatNo.Size = new System.Drawing.Size(123, 21);
        this.rbReheatNo.TabIndex = 4;
        this.rbReheatNo.TabStop = true;
        this.rbReheatNo.Font = new System.Drawing.Font("Segoe UI", 15F);
        this.rbReheatNo.Text = "Не охлаждать";
        this.rbReheatNo.UseVisualStyleBackColor = true;
        
        this.btnServe.Location = new System.Drawing.Point(20, 400);
        this.btnServe.Name = "btnServe";
        this.btnServe.Size = new System.Drawing.Size(350, 60);
        this.btnServe.TabIndex = 5;
        this.btnServe.Text = "Подать";
        this.btnServe.Font = new System.Drawing.Font("Segoe UI", 15F);
        this.btnServe.UseVisualStyleBackColor = true;
        this.btnServe.Click += new System.EventHandler(this.BtnServe_Click);
        
        this.ClientSize = new System.Drawing.Size(400, 400);
        this.Controls.Add(this.btnServe);
        this.Controls.Add(this.rbReheatNo);
        this.Controls.Add(this.rbReheatYes);
        this.Controls.Add(this.txtHistory);
        this.Controls.Add(this.btnAddGarnish);
        this.Controls.Add(this.txtGarnish);
        this.Name = "HotSob";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Собсвенные методы Десерта";
        this.ResumeLayout(false);
        this.PerformLayout();

    }
}
