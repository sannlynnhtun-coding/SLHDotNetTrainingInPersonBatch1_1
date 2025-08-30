using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLHDotNetTrainingInPersonBatch1_1.ConsoleApp
{
    public class AdoDotNetService
    {
        string connectionString = "Data Source=.;Initial Catalog=SLHDotNetTrainingInPersonBatch1;User ID=sa;Password=sasa@123;TrustServerCertificate=True;";
        SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "SLHDotNetTrainingInPersonBatch1",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };

        public void Read()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            #region Read

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

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataRow dr = dt.Rows[i];
            //    string no = dr["StudentNo"].ToString()!;
            //    string name = dr["StudentName"].ToString()!;
            //    Console.WriteLine($"{i + 1} {no} - {name}");
            //}

            #endregion

            connection.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                string no = dr["StudentNo"].ToString()!;
                string name = dr["StudentName"].ToString()!;
                Console.WriteLine($"{i + 1} {no} - {name}");
            }
        }

        public void Create()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = @"SELECT [StudentId]
                  ,[StudentNo]
                  ,[StudentName]
                  ,[FatherName]
                  ,[DateOfBirth]
                  ,[Gender]
                  ,[Address]
                  ,[MobileNo]
                  ,[DeleteFlag]
              FROM [dbo].[Tbl_Student]"; // Create, Update, Delete

            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();

            connection.Close();

            string message = result > 0 ? "Saving Successful." : "Saving Failed.";  
            Console.WriteLine(message);
        }

        public void Update()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string queryInsert = @"
                UPDATE [dbo].[Tbl_Student] Set
                        [StudentName] = 'Ma Ma'
                    WHERE StudentId = 8";

            SqlCommand cmd = new SqlCommand(queryInsert, connection);
            int result = cmd.ExecuteNonQuery();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";

            connection.Close();
        }

        public void Delete()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string queryInsert = @"Update Tbl_Student Set DeleteFlag=1 WHERE StudentId = 8";

            SqlCommand cmd = new SqlCommand(queryInsert, connection);
            int result = cmd.ExecuteNonQuery();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";

            connection.Close();
        }

        public void ExampleMethod()
        {
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
        }
    }
}
