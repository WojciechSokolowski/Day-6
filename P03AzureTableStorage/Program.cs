using Azure;
using Azure.Data.Tables;


string tableName = "Persons";

var tableClient = new TableClient(connectionString, tableName);

// Create a table in your storage account
await tableClient.CreateIfNotExistsAsync();

//// Insert an entity into the table
//var entity = new TableEntity("volleyball", "player6")
//{
//{ "firstname", "john" },
//{ "country", "brasil" },
//{ "phonenumber", "123456789" },
//};
//await tableClient.AddEntityAsync(entity);
//Console.WriteLine("Entity added to the table.");

//// Query entities from the table

//var entity = new TableEntity("volleyball", "player6");

//string partitionKeyFilter = $"PartitionKey eq '{entity.PartitionKey}'";
//await foreach (var e in tableClient.QueryAsync<TableEntity>(partitionKeyFilter))
//{
//    Console.WriteLine($"PartitionKey: {e.PartitionKey}," +
//        $" RowKey: {e.RowKey}, " +
//        $"Property1: { e.GetString("firstname")}, " +
//        $"Property2: {e.GetString("secondname")}, " +
//        $"Property3: {e.GetString("country")}, " +
//        $"Property4: { e.GetString("phonenumber")}, ");
//}

// Update an entity in the table

//var entity = new TableEntity("volleyball", "player6");

//entity["country"] = "UK";
//await tableClient.UpdateEntityAsync(entity, ETag.All);
//Console.WriteLine("Entity updated in the table.");

// Delete an entity from the table

var entity = new TableEntity("volleyball", "player6");

await tableClient.DeleteEntityAsync(entity.PartitionKey, entity.RowKey);
Console.WriteLine("Entity deleted from the table.");