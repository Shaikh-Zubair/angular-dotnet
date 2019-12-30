using System.Collections.Generic;
using System.Threading.Tasks;
using angular_dotnet.Model;
using angular_dotnet.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet.Controllers
{
    public class FeaturesController
    {
        public FeaturesController(AngularDbContext context)
        {
            Context = context;
        }

        public AngularDbContext Context { get; }

        [HttpGet("api/features")]
        public async Task<IEnumerable<Features>> GetFeatures()
        {
            return await Context.Features.ToListAsync();
        }
    }
}