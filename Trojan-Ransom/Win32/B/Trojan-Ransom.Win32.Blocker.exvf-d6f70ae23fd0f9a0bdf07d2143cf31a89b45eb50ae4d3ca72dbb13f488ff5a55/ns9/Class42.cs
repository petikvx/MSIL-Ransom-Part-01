using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns9;

internal class Class42
{
	private readonly ulong[] ulong_0;

	private readonly Dictionary<string, ulong> dictionary_0;

	public Class42(ulong[] ulong_1, Dictionary<string, ulong> dictionary_1)
	{
		ulong_0 = ulong_1;
		dictionary_0 = dictionary_1;
	}

	[SpecialName]
	public Dictionary<string, ulong> method_0()
	{
		return dictionary_0;
	}

	[SpecialName]
	public ulong[] method_1()
	{
		return ulong_0;
	}

	[SpecialName]
	public bool method_2()
	{
		if (ulong_0.Length == 0)
		{
			return dictionary_0.Count == 0;
		}
		return false;
	}
}
