namespace Movies.Contracts.Requests;

/// <summary>
/// A request to create a Movie.
/// </summary>
public class CreateMovieRequest
{
    /// <summary>
    /// The title of the movie being created
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// The year the movie was released
    /// </summary>
    public required int YearOfRelease { get; init; }

    /// <summary>
    /// All the genres the movie belongs to
    /// </summary>
    public required IEnumerable<string> Genres { get; init; } = [];
}