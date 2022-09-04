using System;
using System.Collections.Generic;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

public class UsageCounts
{
	private readonly ulong[] ulong_0;

	private readonly Dictionary<string, ulong> dictionary_0;

	public Dictionary<string, ulong> DynamicFeatureCounts
	{
		get
		{
			try
			{
				return dictionary_0;
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
				return ulong_0;
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
				if (ulong_0.Length == 0)
				{
					return dictionary_0.Count == 0;
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

	public UsageCounts(ulong[] staticFeatureCounts, Dictionary<string, ulong> dynamicFeatureCounts)
	{
		try
		{
			ulong_0 = staticFeatureCounts;
			dictionary_0 = dynamicFeatureCounts;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, staticFeatureCounts, dynamicFeatureCounts);
			throw;
		}
	}
}
