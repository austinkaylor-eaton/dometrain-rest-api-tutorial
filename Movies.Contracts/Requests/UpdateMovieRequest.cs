namespace Movies.Contracts.Requests;

/// <summary>
/// A request to update an existing Movie.
/// </summary>
public class UpdateMovieRequest
{
    /// <summary>
    /// The title of the movie being updated
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