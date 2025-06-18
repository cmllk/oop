using System;
using System.Windows.Forms;

public partial class Hot : Form
{
    public Hot()
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
        HotSv formdessert = new HotSv();
        this.Hide();         
        formdessert.ShowDialog();    
        this.Show();         
    }
    private void btnOpenFormHotPer_Click(object sender, EventArgs e)
    {
        HotPer formdessert = new HotPer();
        this.Hide();           
        formdessert.ShowDialog();    
        this.Show();          
    }
    private void btnOpenFormHotSob_Click(object sender, EventArgs e)
    {
        HotSob formdessert = new HotSob();
        this.Hide();          
        formdessert.ShowDialog();  
        this.Show();          
    }
    private void btnOpenFormHotNas_Click(object sender, EventArgs e)
    {
        HotDishNas formdessert = new HotDishNas();
        this.Hide();           
        formdessert.ShowDialog();   
        this.Show();           
    }
}
