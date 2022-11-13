using APIultimorecode.models;
using Microsoft.EntityFrameworkCore;

namespace APIultimorecode.Data
{
    public class APIdbContext : DbContext
    {
        public APIdbContext(DbContextOptions<APIdbContext> options) : base(options)
        {

        }

        public DbSet<Estado> Estado { get; set; }
    }
}