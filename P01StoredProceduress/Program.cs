// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using System.Data;

Console.WriteLine("Hello, World!");




using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    //insert
    using (SqlCommand command = new SqlCommand("InsertPerson", connection))
    {
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@FirstName", "John");
        command.Parameters.AddWithValue("@LastName", "Doe");
        int rowsAffected = command.ExecuteNonQuery();
        Console.WriteLine($"{rowsAffected} rows affected.");
    }

    //reading 
    //using (SqlCommand command = new SqlCommand("GetAllPersons", connection))
    //{
    //    command.CommandType = CommandType.StoredProcedure;

    //    using (SqlDataReader reader = command.ExecuteReader())
    //    {
    //        while (reader.Read())
    //        {
    //            Console.WriteLine($"" +
    //                $"Id: {reader.GetInt32(0)}, " +
    //                $"FirstName:{ reader.GetString(1)}, " +
    //                $"LastName: { reader.GetString(2)}");
    //        }
    //    }
    //}

    // updating
    //using (SqlCommand command = new SqlCommand("UpdatePerson", connection))
    //{
    //    command.CommandType = CommandType.StoredProcedure;
    //    command.Parameters.AddWithValue("@Id", 1);
    //    command.Parameters.AddWithValue("@FirstName", "UpdatedFirstName");
    //    int rowsAffected = command.ExecuteNonQuery();
    //    Console.WriteLine($"{rowsAffected} rows affected.");
    //}

    //deleting
    //using (SqlCommand command = new SqlCommand("DeletePerson", connection))
    //{
    //    command.CommandType = CommandType.StoredProcedure;
    //    command.Parameters.AddWithValue("@Id", 1);
    //    int rowsAffected = command.ExecuteNonQuery();
    //    Console.WriteLine($"{rowsAffected} rows affected.");
    //}
}

