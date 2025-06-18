using Npgsql;
using System;

public class DbManager1
{
    private string connStr = "Host=localhost;Port=5432;Username=postgres;Password=593052;Database=svo";

    public void SaveDish(string name, string value)
    {
        try
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                var cmd = new NpgsqlCommand("INSERT INTO \"svo\" (\"name\", \"value\") VALUES (@n, @v)", conn);
                cmd.Parameters.AddWithValue("n", name);  
                cmd.Parameters.AddWithValue("v", value);

                int rowsAffected = cmd.ExecuteNonQuery();  

                if (rowsAffected > 0)
                {
                    MessageBox.Show("����� ������� ��������� � ���� ������.");
                }
                else
                {
                    MessageBox.Show("������ ��� ���������� �����.");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"������1: {ex.Message}");
        }
    }
}
