using System;
using System.Collections.Generic;

namespace SkinHarmony.Domain.Entity
{
	public class Routine
	{
            public Guid RoutineId { get; set; }
			public List<Product>? Products { get; set; }

	}
}
