public void GetUserData(int id)
{
    string connectionString = "YourConnectionStringHere";
    string query = $"SELECT * FROM Users WHERE id={id}";

    using (var connection = new SqlConnection(connectionString))
    {
        connection.Open();
        using (var command = new SqlCommand(query, connection))
        {
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"User ID: {reader["Id"]}, Username: {reader["Username"]}");
                }
            }
        }
    }
}
