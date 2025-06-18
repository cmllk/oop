using System;
using System.Windows.Forms;

public partial class Main
    : Form
{
    private DbManager db = new DbManager();

    public Main()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.FixedSingle; 
        this.MaximizeBox = false; 
        this.MinimizeBox = true; 
        this.StartPosition = FormStartPosition.CenterScreen; 
        this.ClientSize = new System.Drawing.Size(1050, 800); 

        //LoadOrders();
    }

    private void btnOpenForm3_Click(object sender, EventArgs e)
    {
        Hot formdessert = new Hot();
        this.Hide();           
        formdessert.ShowDialog();    
        this.Show();           
    }

    private void btnOpenForm2_Click(object sender, EventArgs e)
    {
        DessertF formdessert = new DessertF();
        this.Hide();          
        formdessert.ShowDialog();    
        this.Show();           
    }
}
