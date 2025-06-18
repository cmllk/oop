
using System;
using System.Windows.Forms;
using Npgsql;
using System.Data;

public partial class HotSv : Form
{
    private NpgsqlConnection conn;
    private NpgsqlDataAdapter adapter;
    private DataTable dataTable;
    private NpgsqlCommandBuilder builder;
    public HotSv()
    {
        InitializeComponent();

        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = true;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.ClientSize = new System.Drawing.Size(1600, 800);

        this.FormClosed += HotSv_FormClosed;

        LoadOrders();
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }


    private void HotSv_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (conn != null)
            conn.Close();
    }

    private void LoadOrders()
    {
        try
        {
            if (conn == null)
            {
                conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=593052;Database=orders");
                conn.Open();
            }

            string query = "SELECT \"id\", \"name\", \"value\", \"name1\", \"value1\" FROM \"svo\"";
            adapter = new NpgsqlDataAdapter(query, conn);
            builder = new NpgsqlCommandBuilder(adapter);

            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();

            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["id"] };

            dgvOrders.DataSource = dataTable;
            dgvOrders.Columns["id"].HeaderText = "Номер";
            dgvOrders.Columns["name"].HeaderText = "Общие св-ва";
            dgvOrders.Columns["value"].HeaderText = "Значение";
            dgvOrders.Columns["name1"].HeaderText = "Специальные";
            dgvOrders.Columns["value1"].HeaderText = "Значение";

        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка при загрузке: " + ex.Message);
        }
    }


    private void SaveChanges()
    {
        try
        {

            dgvOrders.EndEdit();
            dgvOrders.BindingContext[dataTable].EndCurrentEdit(); 

            if (dataTable.GetChanges() != null)
            {
                adapter.Update(dataTable);
                MessageBox.Show("Изменения сохранены.");
            }
            else
            {
                MessageBox.Show("Нет изменений для сохранения.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка при сохранении:\n" + ex.ToString());
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvOrders.SelectedRows.Count > 0)
        {
            foreach (DataGridViewRow row in dgvOrders.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dgvOrders.Rows.Remove(row);
                }
            }

            SaveChanges(); 
        }
        else
        {
            MessageBox.Show("Выберите строку для удаления.");
        }
    }



    private void dgvOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        SaveChanges();
    }

    private void rbHot_CheckedChanged(object sender, EventArgs e)
    {
        if (rbHot.Checked)
        {
            lblType.Text = "Название:";
            lblType1.Text = "Цена:";
        }
    }

    private void rbDessert_CheckedChanged(object sender, EventArgs e)
    {
        if (rbDessert.Checked)
        {
            lblType.Text = "Темп. :";
            lblType1.Text = "Т готовки:";
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string value = txtName1.Text.Trim();

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(value))
        {
            MessageBox.Show("Введите все значения.");
            return;
        }

        try
        {
            if (conn == null || conn.State != ConnectionState.Open)
                conn.Open();

            if (lblType.Text == "Название:") // Горячее блюдо
            {
                var selectCmd = new NpgsqlCommand("SELECT \"id\" FROM \"svo\" WHERE \"name\" IS NULL LIMIT 1", conn);
                object result = selectCmd.ExecuteScalar();
                if (result != null)
                {
                    long id = Convert.ToInt64(result);
                    var updateCmd = new NpgsqlCommand("UPDATE \"svo\" SET \"name\" = @name, \"value\" = @value WHERE \"id\" = @id", conn);
                    updateCmd.Parameters.AddWithValue("name", name);
                    updateCmd.Parameters.AddWithValue("value", value);
                    updateCmd.Parameters.AddWithValue("id", id);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Горячее блюдо дополнено.");
                }
                else
                {
                    var insertCmd = new NpgsqlCommand("INSERT INTO \"svo\" (\"name\", \"value\", \"name1\", \"value1\") VALUES (@name, @value, NULL, NULL)", conn);
                    insertCmd.Parameters.AddWithValue("name", name);
                    insertCmd.Parameters.AddWithValue("value", value);
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Горячее блюдо добавлено.");
                }
            }
            else // Десерт
            {
                var selectCmd = new NpgsqlCommand("SELECT \"id\" FROM \"svo\" WHERE \"name1\" IS NULL LIMIT 1", conn);
                object result = selectCmd.ExecuteScalar();
                if (result != null)
                {
                    long id = Convert.ToInt64(result);
                    var updateCmd = new NpgsqlCommand("UPDATE \"svo\" SET \"name1\" = @name1, \"value1\" = @value1 WHERE \"id\" = @id", conn);
                    updateCmd.Parameters.AddWithValue("name1", name);
                    updateCmd.Parameters.AddWithValue("value1", value);
                    updateCmd.Parameters.AddWithValue("id", id);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Собственное св-во добавлено.");
                }
                else
                {
                    var insertCmd = new NpgsqlCommand("INSERT INTO \"svo\" (\"name\", \"value\", \"name1\", \"value1\") VALUES (NULL, NULL, @name1, @value1)", conn);
                    insertCmd.Parameters.AddWithValue("name1", name);
                    insertCmd.Parameters.AddWithValue("value1", value);
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Собственное св-во добавлено.");
                }
            }

            LoadOrders();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка при добавлении: " + ex.Message);
        }
    }
}
