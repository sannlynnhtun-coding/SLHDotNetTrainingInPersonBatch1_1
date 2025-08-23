using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");

string a = "";

// Ctrl + .

//Ctrl + K, C
//Ctrl + K, U

SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
sqlConnectionStringBuilder.DataSource = "."; // Server name
sqlConnectionStringBuilder.InitialCatalog = "SLHDotNetTrainingInPersonBatch1"; // Database name
sqlConnectionStringBuilder.UserID = "sa"; // User name
sqlConnectionStringBuilder.Password = "sasa@123"; // Password
sqlConnectionStringBuilder.TrustServerCertificate = true; // For local development

Console.WriteLine(sqlConnectionStringBuilder.ConnectionString);

SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
connection.Open();
connection.Close();

Console.ReadLine();
//Console.ReadKey();