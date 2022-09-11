using System.Collections.Generic;

namespace ns7;

internal sealed class Class52
{
	private readonly ulong[] ulong_0;

	private readonly Dictionary<string, ulong> dictionary_0;

	public Dictionary<string, ulong> DynamicFeatureCounts => dictionary_0;

	public ulong[] StaticFeatureCounts => ulong_0;

	public bool IsEmpty
	{
		get
		{
			if (ulong_0.Length == 0)
			{
				return dictionary_0.Count == 0;
			}
			return false;
		}
	}

	public Class52(ulong[] staticFeatureCounts, Dictionary<string, ulong> dynamicFeatureCounts)
	{
		ulong_0 = staticFeatureCounts;
		dictionary_0 = dynamicFeatureCounts;
	}
}
