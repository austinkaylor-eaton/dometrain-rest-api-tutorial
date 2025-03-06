using Movies.Domain.Models;

namespace Movies.Contracts.Requests;

/// <summary>
/// A request to update an existing Movie.
/// </summary>
public class UpdateMovieRequest
{
    /// <summary>
    /// The unique identifier of the movie being updated
    /// </summary>
    public Guid Id { get; init; }

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

    /// <summary>
    /// An explicit conversion operator that converts a <see cref="UpdateMovieRequest"/> to a <see cref="Movie"/>
    /// </summary>
    public static explicit operator Movie(UpdateMovieRequest request)
    {
        return new Movie
        {
            Title = request.Title,
            YearOfRelease = request.YearOfRelease,
            Genres = request.Genres.ToList(),
            Id = request.Id
        };
    }

    /// <summary>
    /// An explicit conversion operator that converts a <see cref="Movie"/> to a <see cref="UpdateMovieRequest"/>
    /// </summary>
    public static explicit operator UpdateMovieRequest(Movie movie)
    {
        return new UpdateMovieRequest
        {
            Id = movie.Id,
            Title = movie.Title,
            YearOfRelease = movie.YearOfRelease,
            Genres = movie.Genres
        };
    }
}