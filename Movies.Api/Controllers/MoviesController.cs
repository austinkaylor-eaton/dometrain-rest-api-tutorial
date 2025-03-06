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
    [HttpPost]
    public async Task<IActionResult> CreateMovie([FromBody]CreateMovieRequest request)
    {
        bool wasMovieCreated = await movieRepository.CreateMovieAsync((Movie)request);
        return wasMovieCreated switch
        {
            true => Created(),
            false => BadRequest()
        };
        //return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
    }
}