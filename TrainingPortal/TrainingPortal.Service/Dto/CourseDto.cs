﻿namespace TrainingPortal.Service.Dto
{
	public class CourseDto
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public CategoryDto Category { get; set; }
	}
}