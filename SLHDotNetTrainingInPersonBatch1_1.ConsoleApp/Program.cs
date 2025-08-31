using SLHDotNetTrainingInPersonBatch1_1.ConsoleApp;

AppDbContext db = new AppDbContext();
List<StudentDto> lst = db.Students.ToList();
foreach (var item in lst)
{
    //string a = $"dsnfasid{item.StudentNo}fnsaidfasfnsanf";
    Console.WriteLine($"{item.StudentNo} - {item.StudentName}");
}

StudentDto student = new StudentDto()
{
    StudentNo = "S004",
    Address = "Address 004",
    DateOfBirth = new DateTime(2000, 1, 1), // 1900-01-01 12:00:00 AM
    //DeleteFlag = false,
    FatherName = "Father",
    Gender = "M",
    MobileNo = "0912345678",
    StudentName = "Student 004"
};
db.Students.Add(student);
int result = db.SaveChanges();

StudentDto? editStudent = db.Students.Where(x => x.StudentId == 10).FirstOrDefault();
if (editStudent is not null)
{
    editStudent.FatherName = "New Father Name";
    db.SaveChanges();
}

StudentDto? removeStudent = db.Students.Where(x => x.StudentId == 11).FirstOrDefault();
if (removeStudent is not null)
{
    db.Students.Remove(removeStudent);
    db.SaveChanges();
}

Console.ReadLine();