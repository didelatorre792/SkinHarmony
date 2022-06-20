using System;
using System.Collections.Generic;

namespace Domain.Entity
{
	public class SkincareRoutine
	{
            public Guid skincareRoutineId { get; set; }
			public List<SkincareProduct>? Routine { get; set; }

	}
}
