using System;
using System.Collections.Generic;

namespace Domain.Entity
{
	public class SkincareProduct
	{

		public int skincareProductId { get; set; }
		public string? brand { get; set; }
		public string? name { get; set; }
		public List<string>? ingredientList { get; set; }
		public SkincareRoutine? skincareRoutine { get; set; }
		public Guid skincareRoutineId { get; set; }

	}
}

