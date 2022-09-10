using System.Collections.Generic;

namespace ns3;

internal sealed class Class48
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

	public Class48(ulong[] staticFeatureCounts, Dictionary<string, ulong> dynamicFeatureCounts)
	{
		ulong_0 = staticFeatureCounts;
		dictionary_0 = dynamicFeatureCounts;
	}
}
