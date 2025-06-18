using System;
using System.Windows.Forms;

public partial class DessertF : Form
{
    public DessertF()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.FixedSingle; 
        this.MaximizeBox = false; 
        this.MinimizeBox = true;  
        this.StartPosition = FormStartPosition.CenterScreen; 
        this.ClientSize = new System.Drawing.Size(1050, 800);
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void btnOpenFormHotSv_Click(object sender, EventArgs e)
    {
        DessertSv formdessert = new DessertSv();
        this.Hide();           
        formdessert.ShowDialog();   
        this.Show();         
    }
    private void btnOpenFormHotPer_Click(object sender, EventArgs e)
    {
        DessertPer formdessert = new DessertPer();
        this.Hide();           
        formdessert.ShowDialog();   
        this.Show();          
    }
    private void btnOpenFormHotSob_Click(object sender, EventArgs e)
    {
        DessertSob formdessert = new DessertSob();
        this.Hide();          
        formdessert.ShowDialog();    
        this.Show();          
    }
    private void btnOpenFormHotNas_Click(object sender, EventArgs e)
    {
        DessertNas formdessert = new DessertNas();
        this.Hide();           
        formdessert.ShowDialog();    
        this.Show();          
    }
}
