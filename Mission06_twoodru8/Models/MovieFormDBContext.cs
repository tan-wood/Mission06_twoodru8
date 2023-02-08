using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Mission06_twoodru8.Models
{
	public class MovieFormDBContext : DbContext
	{

		public DbSet<MovieFormModel>? Responses { get; set; }

		protected readonly IConfiguration Configuration;

		public MovieFormDBContext(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var connectionString = configuration.GetConnectionString("MovieDBConnection");
			options.UseSqlite(connectionString);
		}

		protected override void OnModelCreating(ModelBuilder mb)
		{
			mb.Entity<MovieFormModel>().HasData(
				
				new MovieFormModel
				{
					MovieId = 100,
					Category = "Action",
					Title = "Star Wars: Episode III",
					Year = 2005,
					Director = "George Lucas",
					Rating = "PG-13"
				},
				new MovieFormModel
				{
					MovieId = 101,
					Category = "Action",
					Title = "Star Wars: Episode II",
					Year = 2002,
					Director = "George Lucas",
					Rating = "PG"
				},
				new MovieFormModel
				{
					MovieId = 102,
					Category = "Action",
					Title = "Star Wars: Episode I",
					Year = 1999,
					Director = "George Lucas",
					Rating = "PG"
				}


				);
		}
	}
}
