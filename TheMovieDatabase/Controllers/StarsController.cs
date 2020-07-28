using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheMovieDatabase.Data.EFCore;
using TheMovieDatabase.Models;

namespace TheMovieDatabase.Controllers
{
    [Route("api/stars")]
    [ApiController]
    public class StarsController : MyMDBController<Star, EfCoreStarRepository>
    {
        public StarsController(EfCoreStarRepository repository) : base(repository)
        {

        }
    }
}