using ASPNet8ExampleAPI.Models.Enums;

namespace ASPNet8ExampleAPI.Models.DTO
{
    public class ReviewerInformationDTO(int id, string name, string description, ReviewedPlatformsEnum[] reviewedPlatforms)
    {
        public int ID { get; set; } = id;
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public ReviewedPlatformsEnum[] ReviewedPlatforms { get; set; } = reviewedPlatforms;
    }
}
