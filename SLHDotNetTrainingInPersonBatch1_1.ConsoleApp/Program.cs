using Microsoft.Data.SqlClient;
using System.Data;

//SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
//sb.DataSource = ".";
//sb.InitialCatalog = "SLHDotNetTrainingInPersonBatch1";  
//sb.UserID = "sa";
//sb.Password = "sasa@123";
//sb.TrustServerCertificate = true;

SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
{
    DataSource = ".",
    InitialCatalog = "SLHDotNetTrainingInPersonBatch1",
    UserID = "sa",
    Password = "sasa@123",
    TrustServerCertificate = true
};

SqlConnection conn = new SqlConnection(sb.ConnectionString);
conn.Open();

string query = @"SELECT [StudentId]
      ,[StudentNo]
      ,[StudentName]
      ,[FatherName]
      ,[DateOfBirth]
      ,[Gender]
      ,[Address]
      ,[MobileNo]
      ,[DeleteFlag]
  FROM [dbo].[Tbl_Student]";

SqlCommand cmd = new SqlCommand(query, conn);
SqlDataAdapter adapter = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
adapter.Fill(dt);

conn.Close();