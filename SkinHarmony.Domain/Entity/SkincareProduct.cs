using System;
using System.Collections.Generic;

namespace Domain.Entity
{
	public class SkincareProduct
	{

		public int SkincareProductId { get; set; }
		public string? Brand { get; set; }
		public string? Name { get; set; }
		public List<string>? IngredientList { get; set; }
		public SkincareRoutine? SkincareRoutine { get; set; }
		public Guid SkincareRoutineId { get; set; }

	}
}

