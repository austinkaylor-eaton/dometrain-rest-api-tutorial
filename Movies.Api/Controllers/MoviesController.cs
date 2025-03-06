using Microsoft.AspNetCore.Mvc;
using Movies.Application.Repositories;
using Movies.Contracts.Requests;
using Movies.Contracts.Responses;

namespace Movies.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController(IMovieRepository movieRepository) : ControllerBase
{

}