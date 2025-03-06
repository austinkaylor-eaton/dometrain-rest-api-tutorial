using Movies.Application.Models;

namespace Movies.Application.Repositories;

/// <summary>
/// A repository for managing <see cref="Movie"/>s
/// </summary>
public interface IMovieRepository
{
    /// <summary>
    /// Add a <see cref="Movie"/> to the repository
    /// </summary>
    /// <param name="movie"></param>
    /// <returns>
    /// <para><see langword="true"/> if the <see cref="Movie"/> was successfully added</para>
    /// <para><see langword="false"/> if the <see cref="Movie"/> could not be added</para>
    /// <para><see langword="false"/> if the <see cref="Movie"/> already exists</para>
    /// </returns>
    Task<bool> AddMovie(Movie movie);

    /// <summary>
    /// Get all <see cref="Movie"/>s from the repository
    /// </summary>
    /// <returns>
    /// A collection of <see cref="Movie"/>s
    /// </returns>
    Task<IEnumerable<Movie>> GetAllMovies();

    /// <summary>
    /// Get a <see cref="Movie"/> by its ID from the repository
    /// </summary>
    /// <param name="id">The unique identifier of the <see cref="Movie"/></param>
    /// <returns>
    /// <para>The <see cref="Movie"/> if it exists</para>
    /// <para><see langword="null"/> if the <see cref="Movie"/> was not found</para>
    /// </returns>
    Task<Movie?> GetMovieById(Guid id);

    /// <summary>
    /// Update an existing <see cref="Movie"/> in the repository
    /// </summary>
    /// <param name="movie">The <see cref="Movie"/> that currently exists in the repository</param>
    /// <returns>
    /// <para><see langword="true"/> if the <see cref="Movie"/> was successfully updated</para>
    /// <para><see langword="false"/> if the <see cref="Movie"/> was not found</para>
    /// <para><see langword="false"/> if the <see cref="Movie"/> could not be updated</para>
    /// </returns>
    Task<bool> UpdateMovie(Movie movie);

    /// <summary>
    /// Delete a <see cref="Movie"/> by it's unique identifier from the repository
    /// </summary>
    /// <param name="id">The unique identifier of the <see cref="Movie"/></param>
    /// <returns>
    /// <para><see langword="true"/> if the <see cref="Movie"/> was successfully deleted</para>
    /// <para><see langword="false"/> if the <see cref="Movie"/> was not found</para>
    /// <para><see langword="false"/> if the <see cref="Movie"/> could not be deleted</para>
    /// </returns>
    Task<bool> DeleteMovie(Guid id);
}