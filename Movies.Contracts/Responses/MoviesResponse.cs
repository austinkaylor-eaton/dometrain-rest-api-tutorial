using Movies.Domain.Models;

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

    /// <summary>
    /// An explicit conversion operator that converts a collection of <see cref="Movie"/>s to a <see cref="MoviesResponse"/>.
    /// </summary>
    public static explicit operator MoviesResponse(List<Movie> movies)
    {
        return new MoviesResponse
        {
            Movies = movies.Select(movie => (MovieResponse)movie)
        };
    }
}