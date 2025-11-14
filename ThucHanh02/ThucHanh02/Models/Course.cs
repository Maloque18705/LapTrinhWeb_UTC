namespace ThucHanh02.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public string Title { get; set; } = null!;

        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
