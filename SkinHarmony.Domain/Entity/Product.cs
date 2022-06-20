using System;
using System.Collections.Generic;

namespace SkinHarmony.Domain.Entity
{
	public class Product
	{

		public int ProductId { get; set; }
		public string? Brand { get; set; }
		public string? Name { get; set; }
		public List<string>? IngredientList { get; set; }
		public Routine? Routine { get; set; }
		public Guid RoutineId { get; set; }

	}
}

