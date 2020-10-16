using CourseLibrary.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{
	[CourseTitleMustBeDifferentFromDescription(ErrorMessage = "Title must be different than the description")]
	public abstract class CourseForMunipulationDto
	{
		[Required(ErrorMessage = "You should fill out a title.")]
		[MaxLength(100, ErrorMessage = "The title should be less than 100 characters")]
		public string Title { get; set; }

		[MaxLength(1500, ErrorMessage = "The dscription should be less than 1500 characters")]
		public virtual string Description { get; set; }
	}
}
