using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM.Models;
using ASM.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : Controller
    {
        public MoviesController(JsonFileMovieService movieService)
        {
            MovieService = movieService;
        }

        public JsonFileMovieService MovieService { get; }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return MovieService.GetMovies();
        }

        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string MovieId,
            [FromQuery] int Rating)
        {
            MovieService.AddRating(MovieId, Rating);
            return Ok();
        }

        //[HttpPatch]
        //public ActionResult Patch([FromBody] RatingRequest request)
        //{
        //    MovieService.AddRating(request.MovieId, request.Rating);

        //    return Ok();
        //}

        //public class RatingRequest
        //{
        //    public string MovieId { get; set; }
        //    public int Rating { get; set; }
        //}
    }
}
