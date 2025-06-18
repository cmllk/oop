using Npgsql;
using System;

public class DbManager
{
    private string connStr = "Host=localhost;Port=5432;Username=postgres;Password=593052;Database=svoystva";

    public void SaveDish(string name, double price, string type)
    {
        try
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                
                var cmd = new NpgsqlCommand("INSERT INTO \"DishOrder\" (\"Name\", \"Price\", \"Type\") VALUES (@n, @p, @t)", conn);
                cmd.Parameters.AddWithValue("n", name);  
                cmd.Parameters.AddWithValue("p", price);
                cmd.Parameters.AddWithValue("t", type);  

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
            MessageBox.Show($"Ошибка: {ex.Message}");
        }
    }
}
