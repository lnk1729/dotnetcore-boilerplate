using TheMovieDatabase.Models;

namespace TheMovieDatabase.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, TheMovieDBContext>
    {
        public EfCoreMovieRepository(TheMovieDBContext context) : base(context)    
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
