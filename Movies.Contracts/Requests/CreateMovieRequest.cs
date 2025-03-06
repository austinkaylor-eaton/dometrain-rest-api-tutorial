using Movies.Domain.Models;

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

    /// <summary>
    /// An explicit conversion operator that converts a <see cref="CreateMovieRequest"/> to a <see cref="Movie"/>
    /// </summary>
    public static explicit operator Movie(CreateMovieRequest request)
    {
        return new Movie
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
            YearOfRelease = request.YearOfRelease,
            Genres = request.Genres.ToList()
        };
    }

    /// <summary>
    /// An explicit conversion operator that converts a <see cref="Movie"/> to a <see cref="CreateMovieRequest"/>
    /// </summary>
    public static explicit operator CreateMovieRequest(Movie movie)
    {
        return new CreateMovieRequest
        {
            Title = movie.Title,
            YearOfRelease = movie.YearOfRelease,
            Genres = movie.Genres
        };
    }
}