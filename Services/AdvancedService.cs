using ASPNet8ExampleAPI.Models.DTO;
using ASPNet8ExampleAPI.Models.Enums;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Data;

namespace ASPNet8ExampleAPI.Services
{
    public class AdvancedService : IAdvancedService
    {
        private static List<VideoGameDTO> videoGames = [
            new (0, "Command and Conquer: Red Alert 3", "Real time strategy game set in alternate history earth if Einstein suddenly disappeared from history", [0]),
            new (1, "Baldur's Gate 3", "A turn-based tactical RPG featuring a wide array of colorful characters, beautiful maps and intricate D&D 5e based combat", [1, 2])
        ];

        private static List<ReviewDTO> reviews = [
            new (0, "A Prime Example of what an RTS should be like", "A classic base building RTS combined with cheesy humour and featuring cheesy quotable acting from Tim Curry", 9, 0),
            new (1, "A new cult classic", "We're still not sure which character is our favourite, but it's a close toss up between Karlach and Withers", 10, 0),
            new (2, "Difficult for sure", "I found the game to be too difficult for a new player", 6, 1)
        ];

        private static List<ReviewerInformationDTO> reviewers = [
            new (0, "Imaginary Reviews Inc", "Long standing imaginary company set up by John Imaginary", [ReviewedPlatformsEnum.PC, ReviewedPlatformsEnum.XBOX360]),
            new (1, "Averagium Game Journalism", "We hire gamers from all backgrounds", [ReviewedPlatformsEnum.PS3, ReviewedPlatformsEnum.XBOX360, ReviewedPlatformsEnum.NINTENDOSWITCH])
        ];

        public ReviewDTO GetReview(string reviewId)
        {
            var id = int.Parse(reviewId);

            var found = reviews.Where((review) => review.ID == id).First() ?? throw new FileNotFoundException();

            return found;
        }

        public ReviewerInformationDTO GetReviewer(string reviewerId)
        {
            var id = int.Parse(reviewerId);

            var found = reviewers.Where((reviewer) => reviewer.ID == id).First() ?? throw new FileNotFoundException();

            return found;
        }

        public ReviewerInformationDTO GetReviewReviewer(string reviewId)
        {
            var id = int.Parse(reviewId);

            var foundReview = reviews.Where((review) => review.ID == id).First() ?? throw new FileNotFoundException();

            var foundReviewer = reviewers.Where((reviewer) => reviewer.ID == foundReview.ReviewerId).First() ?? throw new FileNotFoundException();

            return foundReviewer;
        }

        public IEnumerable<DisplayReviewDTO> GetReviews(string gameId)
        {
            if (gameId == null)
            {
                throw new BadHttpRequestException("No id provided");
            }

            var id = int.Parse(gameId);

            var found = videoGames.Where((videoGame) => videoGame.ID == id).First();

            if (found == null)
            {
                throw new BadHttpRequestException("Game with the provided id doesn't exist");
            }

            var foundReviews = new List<DisplayReviewDTO>();

            foreach (var reviewId in found.ReviewIds) {
                var reviewFound = reviews.Find((rev) => rev.ID == reviewId);
                if (reviewFound != null)
                {
                    var reviewerFound = reviewers.Find((reviewer) =>  reviewer.ID == reviewFound.ReviewerId);
                    if (reviewerFound != null) {
                        foundReviews.Add(new DisplayReviewDTO(reviewFound, reviewerFound));
                    }
                }
            }

            if (foundReviews.Count == 0)
            {
                throw new FileNotFoundException("No reviews ascociated with that id");
            }

            return foundReviews;
        }

        public VideoGameDTO GetVideoGame(string gameId)
        {
            if (gameId == null)
            {
                throw new BadHttpRequestException("No id provided");
            }

            var id = int.Parse(gameId);

            return videoGames.Where((videoGame) => videoGame.ID == id).First();
        }

        public IEnumerable<VideoGameDTO> GetVideoGames()
        {
            return videoGames;
        }
    }
}
