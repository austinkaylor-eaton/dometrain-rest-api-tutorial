using Movies.Domain.Models;

namespace Movies.Contracts.Responses;

/// <summary>
/// A response containing a Movie.
/// </summary>
public class MovieResponse
{
    /// <summary>
    /// The unique identifier of the movie
    /// </summary>
    /// <remarks>
    /// <para>
    /// Using <see langword="required"/> with <see langword="init"/> means that the property is required when creating the object, but can only be set during object initialization.
    /// </para>
    /// <para>
    /// This results in a read-only property that can be set during object initialization, but not after, which results in a safer runtime experience.
    /// </para>
    /// </remarks>
    public required Guid Id { get; init; }
    
    /// <summary>
    /// The title of the movie
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
    /// An explicit conversion operator that converts a <see cref="Movie"/> to a <see cref="MovieResponse"/>
    /// </summary>
    public static explicit operator MovieResponse(Movie movie)
    {
        return new MovieResponse
        {
            Id = movie.Id,
            Title = movie.Title,
            YearOfRelease = movie.YearOfRelease,
            Genres = movie.Genres
        };
    }

    /// <summary>
    /// An explicit conversion operator that converts a <see cref="MovieResponse"/> to a <see cref="Movie"/>
    /// </summary>
    public static explicit operator Movie(MovieResponse response)
    {
        return new Movie
        {
            Id = response.Id,
            Title = response.Title,
            YearOfRelease = response.YearOfRelease,
            Genres = response.Genres.ToList()
        };
    }
}