using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "Money")]
        public int Budget { get; set; }
        public DateTime StartDate { get; set; } 

        //? tähendab, et see väli võib olla null, st see eiole kohustuslik

        public int? InstructorId { get; set; }

        public Instructor Administrator { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
