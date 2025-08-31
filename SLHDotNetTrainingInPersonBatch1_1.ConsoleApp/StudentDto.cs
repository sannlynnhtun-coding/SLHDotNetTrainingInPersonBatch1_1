using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLHDotNetTrainingInPersonBatch1_1.ConsoleApp
{
    [Table("Tbl_Student")]
    public class StudentDto
    {
        [Key]
        public int StudentId { get; set; }
        //[Column("Student_No")]
        public string StudentNo { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public bool DeleteFlag { get; set; }
    }
}
