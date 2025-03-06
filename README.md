# dometrain-rest-api-tutorial
The code for the Dometrain tutorial - [From Zero to Hero: REST APIs in .NET](https://courses.dometrain.com/courses/take/from-zero-to-hero-rest-apis-in-net)

# Projects
## Movies.Api 
- The REST API for the movies
- Only has items specific to the API like Authentication, Authorization, Controllers, Health-check endpoints, etc.
## Movies.Application
- All the business and infrastructure logic will go in here
- Can use this project with another interface like a console app, web app, etc.
## Movies.Contract
- All the Api contracts reside here
- Publish as a NuGet package and use it in other projects
- Contains DTOs, Request and Response models