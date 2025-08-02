using ASPNet8ExampleAPI.Models.DTO;

namespace ASPNet8ExampleAPI.Services
{
    /// <summary>
    /// Simple Service implementation
    /// </summary>
    public class SimpleService : ISimpleService
    {
        private static List<ExampleObjectDTO> returnObject =
        [
            new() {
                Title = "The Hunt for Red October",
                Description = "Moscow, Washington D.C. and a CIA Analyst track a rouge Soviet Captain and his new submarine.",
                Rating = 10,
                DateAdded = new DateTime(2025, 6, 20),
            },
            new()
            {
                Title = "The Enemy Below",
                Description = "During WWII an American destroyer discovers a German U-boat, and in the ensuing duel the American captain must draw upon all his experience to defeat the equally experienced German commander.",
                Rating = 8,
                DateAdded = new DateTime(2025, 6, 19),
            },
            new() {
                Title = "Greyhound",
                Description = "Several months after the U.S. entry into World War II, an inexperienced U.S. Navy commander must lead an Allied convoy being stalked by a German submarine wolf pack.",
                Rating = 9,
                DateAdded = new DateTime(2025, 7, 20)
            },
            new() {
                Title = "Crimson Tide",
                Description = "On a U.S. nuclear missile sub, a young First Officer stages a mutiny to prevent his trigger-happy Captain from launching his missiles before confirming his orders to do so.",
                Rating = 9,
                DateAdded = new DateTime(2025, 7, 18)
            },
            new() {
                Title = "Kursk",
                Description = "An explosion on a nuclear-powered Russian submarine kills most of the men aboard and causes the few survivors to huddle in waterlogged and oxygen",
                Rating = 7,
                DateAdded = new DateTime(2025, 7, 18)
            },
            new() {
                Title = "Hunter Killer",
                Description = "An untested American submarine captain teams with U.S. Navy Seals to rescue the Russian president, who has been kidnapped by a rogue general.",
                Rating = 5,
                DateAdded = new DateTime(2025, 7, 18)
            },
            new() {
                Title = "K-19: The Widowmaker",
                Description = "When Russia's first nuclear submarine malfunctions on its maiden voyage, the crew must race to save the ship and prevent a nuclear disaster.",
                Rating = 7,
                DateAdded = new DateTime(2025, 7, 20)
            },
            new() {
                Title = "Das Boot",
                Description = "A German U-boat stalks the frigid waters of the North Atlantic as its young crew experience the sheer terror and claustrophobic life of a submariner in World War II.",
                Rating = 10,
                DateAdded = new DateTime(2025, 7, 17)
            }
        ];

        public IEnumerable<ExampleObjectDTO> GetExampleArrayObject()
        {
            return returnObject;
        }

        public string GetExampleText()
        {
            return "This is an example get request output!";
        }

        public string PostExampleText(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return "Api didn't get any text :(";
            }
            string[] adjectives = ["Beautiful", "Charming", "Despicable", "Angry", "Mellow"];
            
            var rand = new Random();
            return $"This is an example POST return: {adjectives[rand.Next(5)]}-{text}";
        }

        public void PostMovieExample(ExampleObjectDTO movieObject)
        {
            if (movieObject == null)
            {
                throw new BadHttpRequestException("Invalid data provided!");
            }

            returnObject.Add(movieObject);
        }
    }
}
