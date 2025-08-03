using ASPNet8ExampleAPI.Models.DTO;

namespace ASPNet8ExampleAPI.Services
{
    public interface IAdvancedService
    {
        IEnumerable<VideoGameDTO> GetVideoGames();

        VideoGameDTO GetVideoGame(string gameId);

        IEnumerable<DisplayReviewDTO> GetReviews(string gameId);

        ReviewDTO GetReview(string reviewId);

        //ReviewDTO PatchReview(string reviewId);

        ReviewerInformationDTO GetReviewer(string reviewerId);

        ReviewerInformationDTO GetReviewReviewer(string reviewId);
    }
}