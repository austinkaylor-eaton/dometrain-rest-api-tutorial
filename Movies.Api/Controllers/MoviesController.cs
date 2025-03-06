using Microsoft.AspNetCore.Mvc;
using Movies.Application.Repositories;
using Movies.Contracts.Requests;
using Movies.Contracts.Responses;
using Movies.Domain.Models;

namespace Movies.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController(IMovieRepository movieRepository) : ControllerBase
{
    /// <summary>
    /// Get a <see cref="Movie"/> by its unique identifier
    /// </summary>
    /// <param name="id">The <see cref="Movie"/>s unique identifier</param>
    /// <returns>
    /// <para>An <see cref="OkResult"/> containing the <see cref="Movie"/></para>
    /// <para>A <see cref="NotFoundResult"/> if the <see cref="Movie"/> was not found</para>
    /// </returns>
    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> GetMovie(Guid id)
    {
        Movie? movie = await movieRepository.GetMovieByIdAsync(id);

        return movie is not null
            ? Ok((MovieResponse)movie)
            : NotFound();
    }

    /// <summary>
    /// Create a new <see cref="Movie"/>
    /// </summary>
    /// <param name="request">The <see cref="CreateMovieRequest"/>, representing the new <see cref="Movie"/> to create</param>
    /// <returns>
    /// <para>A <see cref="CreatedAtActionResult"/> containing the newly created <see cref="Movie"/> with a location to get the new <see cref="Movie"/></para>
    /// <para>A <see cref="BadRequestResult"/> if the <see cref="Movie"/> could not be created</para>
    /// </returns>
    [HttpPost]
    public async Task<IActionResult> CreateMovie([FromBody]CreateMovieRequest request)
    {
        Movie movieToCreate = (Movie)request;
        bool wasMovieCreated = await movieRepository.CreateMovieAsync(movieToCreate);

        return wasMovieCreated switch
        {
            true => CreatedAtAction(nameof(GetMovie), new { id = movieToCreate.Id }, movieToCreate),
            false => BadRequest()
        };
    }
}