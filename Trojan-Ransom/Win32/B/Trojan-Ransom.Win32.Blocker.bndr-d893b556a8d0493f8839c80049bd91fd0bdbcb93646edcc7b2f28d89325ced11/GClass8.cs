using System.Collections.Generic;

public class GClass8
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

	public GClass8(ulong[] ulong_1, Dictionary<string, ulong> dictionary_1)
	{
		ulong_0 = ulong_1;
		dictionary_0 = dictionary_1;
	}
}
