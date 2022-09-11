using System;
using System.Collections.Generic;

namespace ns0;

internal sealed class Class3
{
	private bool? nullable_0;

	private Dictionary<string, Class2> dictionary_0;

	internal UriIdnScope? nullable_1;

	public UriIdnScope? Nullable_0
	{
		get
		{
			return nullable_1;
		}
		set
		{
			UriIdnScope? val = (nullable_1 = value);
		}
	}

	public bool? Nullable_1
	{
		get
		{
			return nullable_0;
		}
		set
		{
			nullable_0 = value;
		}
	}

	public Dictionary<string, Class2> Dictionary_0 => dictionary_0;

	public Class3()
	{
		dictionary_0 = new Dictionary<string, Class2>();
	}
}
