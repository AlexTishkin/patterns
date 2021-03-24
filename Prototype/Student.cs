namespace Prototype
{
    /// <summary>
    /// Студент
    /// </summary>
    public class Student : Human
    {
        public int StudentId { get; set; }
        public int Course { get; set; }

        public Student() { }

        public Student(Student anotherStudent) : base(anotherStudent)
        {
            StudentId = anotherStudent.StudentId;
            Course = anotherStudent.Course;
        }

        public override object Clone() => new Student(this);

        public override string ToString() => $"[{StudentId}: {Name}, {Age} лет, {Course} курс]";
    }
}
