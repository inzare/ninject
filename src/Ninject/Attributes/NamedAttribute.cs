﻿using System;
using Ninject.Planning.Bindings;

namespace Ninject
{
	public class NamedAttribute : ConstraintAttribute
	{
		public string Name { get; set; }

		public NamedAttribute(string name)
		{
			Name = name;
		}

		public override bool Matches(IBindingMetadata obj)
		{
			return obj.Name == Name;
		}
	}
}