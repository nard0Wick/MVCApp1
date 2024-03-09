using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;//permite agregar algunas etiquetas para complementar
												   //la validación y el formato de los datos

namespace MVCApp1.Models
{
	public class Movie
	{
		public int Id { get; set; }

		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string? Title { get; set; }

		[Display(Name = "Release Date")]
		[DataType(DataType.Date)]
		[Required]
		public DateTime RealeseDate { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
		[Required]
		[StringLength(30)]
		public string? Genre {  get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		[Range(1, 100)]
		[Required]
		public decimal Price { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
		[StringLength(5)]
		[Required]
		public string? Raiting { get; set; }

	}
}
