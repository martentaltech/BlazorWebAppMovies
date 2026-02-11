using Microsoft.EntityFrameworkCore;

public class BlazorWebAppMovieContext(DbContextOptions<BlazorWebAppMovieContext> options) : DbContext(options)
{
    public DbSet<BlazorWebAppMovies.Models.Movie> Movie { get; set; } = default!;
}
