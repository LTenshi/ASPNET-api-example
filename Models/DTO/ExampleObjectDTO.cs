namespace ASPNet8ExampleAPI.Models.DTO
{
    public class ExampleObjectDTO
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public int Rating { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
