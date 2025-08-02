namespace ASPNet8ExampleAPI.Models.DTO
{
    public class VideoGameDTO(int id, string title, string description, List<int> reviewIds)
    {
        public int ID { get; set; } = id;
        public string Title { get; set; } = title;
        public string Description { get; set; } = description;
        public List<int> ReviewIds { get; set; } = reviewIds;
    }
}
