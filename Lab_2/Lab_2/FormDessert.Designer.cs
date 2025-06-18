partial class FormDessert
{
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnDessertSv;
    private System.Windows.Forms.Button btnDessertSpec;
    private System.Windows.Forms.Button btnDessertNasl;
    private System.Windows.Forms.Button btnDessertPereopr;
    private void InitializeComponent()
    {
        this.lblTitle = new System.Windows.Forms.Label();
        this.btnDessertSv = new System.Windows.Forms.Button();
        this.btnDessertSpec = new System.Windows.Forms.Button();
        this.btnDessertNasl = new System.Windows.Forms.Button();
        this.btnDessertPereopr = new System.Windows.Forms.Button();

        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(230, 120);
        this.lblTitle.Text = "Св-ва/Методы Дессерта";
        this.Controls.Add(this.lblTitle);

        this.btnDessertSv.Location = new System.Drawing.Point(300, 270);
        this.btnDessertSv.Size = new System.Drawing.Size(500, 70);
        this.btnDessertSv.Text = "Общие/Собственные";
        this.btnDessertSv.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.btnDessertSv.Click += new System.EventHandler(this.btnOpenFormHotSv_Click);
        this.Controls.Add(this.btnDessertSv);
          
        this.btnDessertSpec.Location = new System.Drawing.Point(300, 370);
        this.btnDessertSpec.Size = new System.Drawing.Size(500, 70);
        this.btnDessertSpec.Text = "Специальные";
        this.btnDessertSpec.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.Controls.Add(this.btnDessertSpec);

        
       
        this.btnDessertNasl.Location = new System.Drawing.Point(300, 470);
        this.btnDessertNasl.Size = new System.Drawing.Size(500, 70);
        this.btnDessertNasl.Text = "Наследуемые";
        this.btnDessertNasl.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.Controls.Add(this.btnDessertNasl);

        
        this.btnDessertPereopr.Location = new System.Drawing.Point(300, 570);
        this.btnDessertPereopr.Size = new System.Drawing.Size(500, 70);
        this.btnDessertPereopr.Text = "Переопределяющие";
        this.btnDessertPereopr.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.Controls.Add(this.btnDessertPereopr);

        this.Text = "Св-ва/Методы Дессерта";
    }
}
