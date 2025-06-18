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
                    MessageBox.Show("Блюдо успешно сохранено в базу данных.");
                }
                else
                {
                    MessageBox.Show("Ошибка при сохранении блюда.");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка1: {ex.Message}");
        }
    }
}
