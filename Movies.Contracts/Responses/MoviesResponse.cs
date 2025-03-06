namespace Movies.Contracts.Responses;

/// <summary>
/// A response containing a collection of Movies.
/// </summary>
public class MoviesResponse
{
    /// <summary>
    /// A collection of Movies.
    /// </summary>
    public required IEnumerable<MovieResponse> Movies { get; init; } = [];
}