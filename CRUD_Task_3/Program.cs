using MySql.Data.MySqlClient;

public class CRUD_Task_3
{
    public static void Main(string[] args)
    {
        // Modify connection string here 
        string connectionString = "server=___;port=___;user=___;password=___;database=___;";

        // Write & Modify code below this line
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string cmdText = "your query here";
            MySqlCommand cmd = new MySqlCommand(cmdText, connection);
        }
        // Write & Modify code above this line
    }
}