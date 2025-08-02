namespace ASPNet8ExampleAPI.Models.DTO
{
    public class DisplayReviewDTO(ReviewDTO review, ReviewerInformationDTO reviewer)
    {
        public ReviewDTO Review { get; set; } = review;
        public ReviewerInformationDTO Reviewer { get; set; } = reviewer;
    }
}
