using System.Collections.Generic;

namespace SmartAssembly.SmartUsageCore;

public class UsageCounts
{
	private readonly ulong[] m_StaticFeatureCounts;

	private readonly Dictionary<string, ulong> m_DynamicFeatureCounts;

	public Dictionary<string, ulong> DynamicFeatureCounts => m_DynamicFeatureCounts;

	public ulong[] StaticFeatureCounts => m_StaticFeatureCounts;

	public bool IsEmpty
	{
		get
		{
			if (m_StaticFeatureCounts.Length == 0)
			{
				return m_DynamicFeatureCounts.Count == 0;
			}
			return false;
		}
	}

	public UsageCounts(ulong[] staticFeatureCounts, Dictionary<string, ulong> dynamicFeatureCounts)
	{
		m_StaticFeatureCounts = staticFeatureCounts;
		m_DynamicFeatureCounts = dynamicFeatureCounts;
	}
}
