using System.ComponentModel.DataAnnotations;

namespace Mission06_twoodru8.Models
{
	public class MovieFormModel
	{

		[Key]
		[Required]
		public int MovieId { get; set; }
		[Required]
		public string? Title { get; set; }
		[Required]
		[Range(1900, 2023)]
		public int? Year { get; set; }
		[Required]
		public string? Director { get; set; }
		[Required]
		public string? Category { get; set; }
		[Required]
		public string? Rating { get; set; }
		public char? Edited { get; set; }
		public string? LentTo { get; set; }
		[StringLength(25)]
		public string? Notes { get; set; }


	}
}
