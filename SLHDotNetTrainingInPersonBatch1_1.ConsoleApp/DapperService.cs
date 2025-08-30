using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLHDotNetTrainingInPersonBatch1_1.ConsoleApp
{
    public class DapperService
    {
        private readonly SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "SLHDotNetTrainingInPersonBatch1",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };

        public void Read()
        {
            using IDbConnection db = new SqlConnection(sb.ConnectionString);
            db.Open();
            List<Student> lst = db.Query<Student>("select * from tbl_student").ToList();
            for (int i = 0; i < lst.Count; i++)
            {
                Student item = lst[i];
                Console.WriteLine($"{i + 1} {item.StudentNo} - {item.StudentName}");
            }
        }

        public void Create()
        {
            using IDbConnection db = new SqlConnection(sb.ConnectionString);
            db.Open();
            int result = db.Execute("");
        }

        public void Update()
        {
            using IDbConnection db = new SqlConnection(sb.ConnectionString);
            db.Open();
            int result = db.Execute("");
        }   

        public void Delete()
        {
            using IDbConnection db = new SqlConnection(sb.ConnectionString);
            db.Open();
            int result = db.Execute("");
        }
    }
}
