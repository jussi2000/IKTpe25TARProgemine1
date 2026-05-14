using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class OfficeAssignment
    {
        //kui soovite konkreetselt välja tuua, et InstructorId on nii OfficeAssignmenti
        //peaminevõti kui ka võõrvõti, siis saate kasutada [Key] ja [ForeignKey] atribuute:
        [Key]

        public int InstructorId { get; set; }

        public string Location { get; set; } = string.Empty;

        public Instructor Instructor { get; set; }
    }
}
