namespace MovieApi.Domain.Entities
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string ReviewComment { get; set; }
        public byte ReviewRating { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool ReviewStatus { get; set; }
    }
}