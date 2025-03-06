namespace Movies.Domain.Models;

/// <summary>
/// A movie in the application.
/// </summary>
/// <remarks>
/// <para>This is a domain model, which is used to represent the data in the application.</para>
/// <para>This is saved to some persistent storage, such as a database.</para>
/// </remarks>
public class Movie
{
    /// <summary>
    /// The unique identifier of the movie
    /// </summary>
    public required Guid Id { get; set; }

    /// <summary>
    /// The title of the movie
    /// </summary>
    /// <remarks>
    /// <para>Has a setter because it can be set during runtime</para>
    /// </remarks>
    public required string Title { get; set; }

    /// <summary>
    /// The year the movie was released
    /// </summary>
    /// <remarks>
    /// <para>Has a setter because it can be set during runtime</para>
    /// </remarks>
    public required int YearOfRelease { get; set; }

    /// <summary>
    /// The genres the movie belongs to
    /// </summary>
    public required List<string> Genres { get; init; } = [];
}