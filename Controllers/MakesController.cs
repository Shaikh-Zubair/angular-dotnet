using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using angular_dotnet.Models;
using angular_dotnet.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet.Controllers
{
    public class MakesController : Controller
    {
        public AngularDbContext Context { get; }
        public MakesController(AngularDbContext context)
        {
            this.Context = context;
        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            Console.WriteLine("context");
            return await Context.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}