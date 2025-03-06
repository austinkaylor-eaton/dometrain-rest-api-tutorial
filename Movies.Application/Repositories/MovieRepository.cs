using Movies.Domain.Models;

namespace Movies.Application.Repositories;

public class MovieRepository : IMovieRepository
{
    /// <summary>
    /// Represents an in-memory collection of <see cref="Movie"/>s
    /// </summary>
    private readonly List<Movie> _movies = [];

    /// <inheritdoc />
    public Task<bool> CreateMovieAsync(Movie movie)
    {
        _movies.Add(movie);
        return Task.FromResult(true);
    }

    /// <inheritdoc />
    public Task<IEnumerable<Movie>> GetAllMoviesAsync()
    {
        return Task.FromResult(_movies.AsEnumerable());
    }

    /// <inheritdoc />
    public async Task<Movie?> GetMovieByIdAsync(Guid id)
    {
        Movie? movie = _movies.SingleOrDefault(m => m.Id == id);
        return await Task.FromResult(movie);
    }

    /// <inheritdoc />
    public Task<bool> UpdateMovieAsync(Movie movie)
    {
        int index = _movies.FindIndex(m => m.Id == movie.Id);
        if (index == -1)
            return Task.FromResult(false);

        _movies[index] = movie;
        return Task.FromResult(true);
    }

    /// <inheritdoc />
    public Task<bool> DeleteMovieAsync(Guid id)
    {
        int moviesDeleted = _movies.RemoveAll(m => m.Id == id);
        return Task.FromResult(moviesDeleted > 0);
    }
}