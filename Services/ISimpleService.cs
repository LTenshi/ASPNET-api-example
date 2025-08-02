using ASPNet8ExampleAPI.Models.DTO;

namespace ASPNet8ExampleAPI.Services
{
    /// <summary>
    /// Interface for a simple service provider
    /// </summary>
    public interface ISimpleService
    {
        /// <summary>
        /// Returns a simple example string
        /// </summary>
        /// <returns></returns>
        string GetExampleText();
        
        /// <summary>
        /// Returns a simple array of example objects
        /// </summary>
        /// <returns></returns>
        IEnumerable<ExampleObjectDTO> GetExampleArrayObject();

        /// <summary>
        /// Sends some example text to the API and returns the text with an adjective
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string PostExampleText(string text);

        /// <summary>
        /// Posts an example movie and adds it to the list gettable with GetExampleArrayObject endpoint
        /// </summary>
        /// <param name="movieObject"></param>
        void PostMovieExample(ExampleObjectDTO movieObject);
    }
}
