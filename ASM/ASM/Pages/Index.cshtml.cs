using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM.Models;
using ASM.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ASM.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,
              JsonFileMovieService movieService)
        {
            _logger = logger;
            MovieService = movieService;
        }


        public JsonFileMovieService MovieService { get; }
        public IEnumerable<Movie> Movies { get; private set; }

        public void OnGet()
        {
            Movies = MovieService.GetMovies();
        }
    }
}
