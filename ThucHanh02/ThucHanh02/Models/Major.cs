namespace ThucHanh02.Models
{
    public class Major
    {
        public int MajorId { get; set; }

        public string MajorName { get; set; } = null!;

        public virtual ICollection<Learner> Learners { get; set; } = new List<Learner>();
    }
}
