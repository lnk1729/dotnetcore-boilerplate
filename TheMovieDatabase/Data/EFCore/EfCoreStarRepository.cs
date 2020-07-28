using TheMovieDatabase.Models;

namespace TheMovieDatabase.Data.EFCore
{
    public class EfCoreStarRepository : EfCoreRepository<Star, TheMovieDBContext>
    {
        public EfCoreStarRepository(TheMovieDBContext context) : base(context)
        {

        }       
    }
}
