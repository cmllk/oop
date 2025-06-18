
    partial class DessertNas
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox ComboBoxDishes;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.Button BtnCook;
        private System.Windows.Forms.Button BtnPack;
        private System.Windows.Forms.Button btnClose;

    protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ComboBoxDishes = new System.Windows.Forms.ComboBox();
            this.BtnCook = new System.Windows.Forms.Button();
            this.lblType1 = new System.Windows.Forms.Label();
            this.BtnPack = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

        this.btnClose.Location = new System.Drawing.Point(500, 600); 
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(350, 60);
        this.btnClose.TabIndex = 6;
        this.btnClose.Text = "Назад";
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15F);
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
        this.Controls.Add(this.btnClose);


        this.ComboBoxDishes.FormattingEnabled = true;
            this.ComboBoxDishes.Location = new System.Drawing.Point(200, 120);
            this.ComboBoxDishes.Name = "ComboBoxDishes";
            this.ComboBoxDishes.Size = new System.Drawing.Size(200, 40);
            this.ComboBoxDishes.TabIndex = 0;
            this.ComboBoxDishes.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ComboBoxDishes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDishes_SelectedIndexChanged);

            this.BtnCook.Location = new System.Drawing.Point(150, 200);
            this.BtnCook.Name = "BtnCook";
            this.BtnCook.Size = new System.Drawing.Size(300, 60);
            this.BtnCook.TabIndex = 1;
            this.BtnCook.Text = "Приготовить";
            this.BtnCook.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.BtnCook.UseVisualStyleBackColor = true;
            this.BtnCook.Click += new System.EventHandler(this.BtnCook_Click);

            this.BtnPack.Location = new System.Drawing.Point(150, 260);
            this.BtnPack.Name = "BtnPack";
            this.BtnPack.Size = new System.Drawing.Size(300, 60);
            this.BtnPack.TabIndex = 2;
            this.BtnPack.Text = "Упаковать";
            this.BtnPack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.BtnPack.UseVisualStyleBackColor = true;
            this.BtnPack.Click += new System.EventHandler(this.BtnPack_Click);

            this.TxtResult.Location = new System.Drawing.Point(150, 330);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResult.Size = new System.Drawing.Size(300, 350);
            this.TxtResult.TabIndex = 3;

            this.lblType1.AutoSize = true;
            this.lblType1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblType1.Location = new System.Drawing.Point(100, 30);
            this.lblType1.Text = "Выберите Дессерт:";
            this.Controls.Add(this.lblType1);

            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnPack);
            this.Controls.Add(this.BtnCook);
            this.Controls.Add(this.ComboBoxDishes);
            this.Name = "DessertNas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор блюда";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
