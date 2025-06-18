partial class DessertF
{
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnHotDishSv;
    private System.Windows.Forms.Button btnHotDishSpec;
    private System.Windows.Forms.Button btnHotDishNasl;
    private System.Windows.Forms.Button btnHotDishPereopr;
    private System.Windows.Forms.Button btnClose;
    private void InitializeComponent()
    {
        this.lblTitle = new System.Windows.Forms.Label();
        this.btnHotDishSv = new System.Windows.Forms.Button();
        this.btnHotDishSpec = new System.Windows.Forms.Button();
        this.btnHotDishNasl = new System.Windows.Forms.Button();
        this.btnHotDishPereopr = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();


        this.btnClose.Location = new System.Drawing.Point(300, 670); 
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(500, 70);
        this.btnClose.TabIndex = 6;
        this.btnClose.Text = "Назад";
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15F);
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
        this.Controls.Add(this.btnClose);

         
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(170, 100);
        this.lblTitle.Text = "Св-ва/Методы Дессерта";
        this.Controls.Add(this.lblTitle);

        
        this.btnHotDishSv.Location = new System.Drawing.Point(300, 270);
        this.btnHotDishSv.Size = new System.Drawing.Size(500, 70);
        this.btnHotDishSv.Text = "Общие/Специальные";
        this.btnHotDishSv.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.btnHotDishSv.Click += new System.EventHandler(this.btnOpenFormHotSv_Click);
        this.Controls.Add(this.btnHotDishSv);

        
        this.btnHotDishSpec.Location = new System.Drawing.Point(300, 370);
        this.btnHotDishSpec.Size = new System.Drawing.Size(500, 70);
        this.btnHotDishSpec.Text = "Cобственные";
        this.btnHotDishSpec.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.btnHotDishSpec.Click += new System.EventHandler(this.btnOpenFormHotSob_Click);
        this.Controls.Add(this.btnHotDishSpec);

        this.btnHotDishNasl.Location = new System.Drawing.Point(300, 470);
        this.btnHotDishNasl.Size = new System.Drawing.Size(500, 70);
        this.btnHotDishNasl.Text = "Наследуемые";
        this.btnHotDishNasl.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.btnHotDishNasl.Click += new System.EventHandler(this.btnOpenFormHotNas_Click);
        this.Controls.Add(this.btnHotDishNasl);

        this.btnHotDishPereopr.Location = new System.Drawing.Point(300, 570);
        this.btnHotDishPereopr.Size = new System.Drawing.Size(500, 70);
        this.btnHotDishPereopr.Text = "Переопределяющие";
        this.btnHotDishPereopr.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.btnHotDishPereopr.Click += new System.EventHandler(this.btnOpenFormHotPer_Click);
        this.Controls.Add(this.btnHotDishPereopr);

        this.Text = "Св-ва/Методы Дессерта";
    }
}
