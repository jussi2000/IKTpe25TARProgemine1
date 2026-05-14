using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        [Column("FirstName")]
        public string FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        //Mis on ICollection?
        //ICollection on nimekiri, mis võimaldab hoida mitit objecti.

        public ICollection<CourseAssignment> CourseAssignments { get; set; }

        //Miks siin ei kasutata ICollection, Vaid lihtsaltOfficeAssignment?

        //Sest OfficeAssignment on üks-ühele seos Instructoriga, st iga õpetaja
        //võib omada ainult ühte kontoripinda. Seega ei ole vaja kasutada
        //ICollectioni, kuna ei ole vaja hoida mitut OfficeAssignment objekti.
        //Kui kasutaksime ICollectioni, siis see tähendaks, et õpetaja
        //võiks omada mitut kontoripinda, mis ei ole meie mudelis korrektne.

        public OfficeAssignment OfficeAssignments { get; set; }
    }
}
