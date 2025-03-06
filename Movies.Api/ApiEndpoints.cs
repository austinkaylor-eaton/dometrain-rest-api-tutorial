namespace Movies.Api;

/// <summary>
/// Contains all the API endpoints for the Movies API
/// </summary>
/// <remarks>
/// In order to use any of these endpoints, you would need to remove the <c>[Route("api/[controller]")]</c> attribute from the controller
/// </remarks>
public static class ApiEndpoints
{
    /// <summary>
    /// The base path for all API endpoints
    /// </summary>
    private const string Root = "api";

    /// <summary>
    /// Provides endpoints for managing movies
    /// </summary>
    public static class Movies
    {
        /// <summary>
        /// The base path for all movie related API endpoints
        /// </summary>
        public const string Base = Root + "/movies";

        /// <summary>
        /// The endpoint for getting all movies
        /// </summary>
        public const string GetAll = Base;

        /// <summary>
        /// The endpoint for getting a movie by its unique identifier
        /// </summary>
        public const string GetById = Base + "/{id:Guid}";

        /// <summary>
        /// The endpoint for creating a new movie
        /// </summary>
        /// <remarks>
        /// In order to use this, you would set the HttpPost attribute to <c>[HttpPost(ApiEndpoints.Movies.Create)]</c>
        /// </remarks>
        public const string Create = Base;

        /// <summary>
        /// The endpoint for updating an existing movie
        /// </summary>
        public const string Update = Base + "/{id:Guid}";

        /// <summary>
        /// The endpoint for deleting a movie by its unique identifier
        /// </summary>
        public const string Delete = Base + "/{id:Guid}";
    }
}