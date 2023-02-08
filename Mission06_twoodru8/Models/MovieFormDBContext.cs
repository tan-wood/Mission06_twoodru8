using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Mission06_twoodru8.Models
{
	public class MovieFormDBContext : DbContext
	{
		//Setting the title of the table
		public DbSet<MovieFormModel>? Responses { get; set; }

		//Adding a Interface of the configuration
		protected readonly IConfiguration Configuration;

		//setting the configuration to this classes config
		public MovieFormDBContext(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		//overriding the DBContext onconfiguring method and setting up all the connection strings etc
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			//building the configuration adding the appsettings.json and then building that so that then we can access the connection string
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();
			//grabbing connection string
			var connectionString = configuration.GetConnectionString("MovieDBConnection");
			//using sqlite with our connection
			options.UseSqlite(connectionString);
		}

		protected override void OnModelCreating(ModelBuilder mb)
		{
			//Seeding the data with my 3 favorite movies
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
