using Dapper;
using Microsoft.Data.SqlClient;
using SLHDotNetTrainingInPersonBatch1_1.ConsoleApp;
using System.Collections.Generic;
using System.Data;

SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
{
    DataSource = ".",
    InitialCatalog = "SLHDotNetTrainingInPersonBatch1",
    UserID = "sa",
    Password = "sasa@123",
    TrustServerCertificate = true
};

//using (IDbConnection db = new SqlConnection(sb.ConnectionString))
//{
//    db.Open();
//    var query = db.Query<Student>("select * from tbl_student");
//    List<Student> lst = query.ToList();
//}

using IDbConnection db = new SqlConnection(sb.ConnectionString);
db.Open();
List<Student> lst = db.Query<Student>("select * from tbl_student").ToList();
for (int i = 0; i < lst.Count; i++)
{
    Student item = lst[i];
    Console.WriteLine($"{i + 1} {item.StudentNo} - {item.StudentName}");
}

int no = 0;
foreach (Student item in lst)
{
    Console.WriteLine($"{no + 1} {item.StudentNo} - {item.StudentName}");
    no++;
}

//var query = db.Query<Student>("select * from tbl_student");
//List<Student> lst = query.ToList();

Console.ReadLine();

//ITransfer transfer = new WavePayTransfer();
//transfer.Transfer();

//transfer = new KPayTransfer();
//transfer.Transfer();


//public interface ITransfer
//{
//    void Transfer();
//    void TransactionHistory();
//}

//public class WavePayTransfer : ITransfer
//{
//    public void TransactionHistory()
//    {
//        Console.WriteLine("Wave Pay Transaction History");
//    }

//    public void Transfer()
//    {
//        Console.WriteLine("Wave Pay Transfer");
//    }
//}

//public class KPayTransfer : ITransfer
//{
//    public void TransactionHistory()
//    {
//        Console.WriteLine("KPay Transaction History");
//    }

//    public void Transfer()
//    {
//        Console.WriteLine("KPay Transfer");
//    }
//}
