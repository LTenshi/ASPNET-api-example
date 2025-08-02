namespace ASPNet8ExampleAPI.Models.DTO
{
    public class ReviewDTO(int id, string title, string reviewText, int rating, int reviewerId)
    {
        public int ID { get; set; } = id;
        public string Title { get; set; } = title;
        public string ReviewText { get; set; } = reviewText;
        public int Rating { get; set; } = rating;
        public int ReviewerId { get; set; } = reviewerId;
    }
}
