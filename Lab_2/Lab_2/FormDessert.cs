using System;
using System.Windows.Forms;

public partial class FormDessert : Form
{
    public FormDessert()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.FixedSingle; 
        this.MaximizeBox = false; 
        this.MinimizeBox = true; 
        this.StartPosition = FormStartPosition.CenterScreen; 
        this.ClientSize = new System.Drawing.Size(1050, 800);
    }
    private void btnOpenFormHotSv_Click(object sender, EventArgs e)
    {
        DessertSv formdessert = new DessertSv();
        this.Hide();          
        formdessert.ShowDialog();    
        this.Show();          
    }
}
