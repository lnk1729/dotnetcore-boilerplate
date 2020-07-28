using Microsoft.AspNetCore.Mvc;
using TheMovieDatabase.Data.EFCore;
using TheMovieDatabase.Models;

namespace TheMovieDatabase.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : MyMDBController<Movie, EfCoreMovieRepository>
    {
        public MoviesController(EfCoreMovieRepository repository) : base(repository)
        {

        }
    }
}
