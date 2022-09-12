using System;
using System.Collections.Generic;

namespace Yakari;

public class SimpleContext
{
	public Dictionary<string, object> Items { get; }

	public object this[string name]
	{
		get
		{
			return Items[name];
		}
		set
		{
			Items[name] = value;
		}
	}

	public Exception Exception { get; }

	public SimpleContext()
	{
		Items = new Dictionary<string, object>(Convert.ToInt32(10.0));
	}

	public SimpleContext(Exception exception)
		: this()
	{
		Exception = exception;
	}
}
