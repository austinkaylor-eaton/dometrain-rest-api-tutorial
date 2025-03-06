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
}