
namespace LinqAllAny
{
    public class StudentData
    {
        public static readonly List<Student> students = new List<Student>()
        {
            new Student() {studentId = 1, Name = "John", Age = 13, StandartId = 1},
            new Student() {studentId = 2, Name = "Jelizaveta", Age = 21, StandartId = 1},
            new Student() {studentId = 3, Name = "moosipall", Age = 18, StandartId = 2},
            new Student() {studentId = 4, Name = "Pipi pupu", Age = 20, StandartId = 2},
            new Student() {studentId = 5, Name = "Piu-Piu", Age = 15},
        };
    }
}
