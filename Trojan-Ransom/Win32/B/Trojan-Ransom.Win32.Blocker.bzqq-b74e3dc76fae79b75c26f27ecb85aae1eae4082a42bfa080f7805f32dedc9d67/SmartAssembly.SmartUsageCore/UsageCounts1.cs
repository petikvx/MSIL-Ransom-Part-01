using System;
using System.Collections.Generic;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

public class UsageCounts1
{
	private readonly ulong[] m_StaticFeatureCounts;

	private readonly Dictionary<string, ulong> m_DynamicFeatureCounts;

	public Dictionary<string, ulong> DynamicFeatureCounts
	{
		get
		{
			try
			{
				return m_DynamicFeatureCounts;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	public ulong[] StaticFeatureCounts
	{
		get
		{
			try
			{
				return m_StaticFeatureCounts;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	public bool IsEmpty
	{
		get
		{
			try
			{
				if (m_StaticFeatureCounts.Length == 0)
				{
					return m_DynamicFeatureCounts.Count == 0;
				}
				return false;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	public UsageCounts1(ulong[] staticFeatureCounts, Dictionary<string, ulong> dynamicFeatureCounts)
	{
		try
		{
			m_StaticFeatureCounts = staticFeatureCounts;
			m_DynamicFeatureCounts = dynamicFeatureCounts;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, staticFeatureCounts, dynamicFeatureCounts);
			throw;
		}
	}
}
