using Fiorello_PB101.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_PB101.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
           public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SlidersInfos { get; set;}
        
    }
}
