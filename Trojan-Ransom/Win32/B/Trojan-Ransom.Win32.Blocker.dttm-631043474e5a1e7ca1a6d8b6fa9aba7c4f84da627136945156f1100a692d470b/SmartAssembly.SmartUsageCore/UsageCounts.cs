using System;
using System.Collections.Generic;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

public class UsageCounts
{
	private readonly Dictionary<string, ulong> dictionary_0;

	internal ulong[] ulong_0;

	public Dictionary<string, ulong> DynamicFeatureCounts
	{
		get
		{
			try
			{
				return dictionary_0;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, this);
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
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, this);
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
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, this);
				throw;
			}
		}
	}

	public UsageCounts(ulong[] ulong_1, Dictionary<string, ulong> dictionary_1)
	{
		try
		{
			ulong[] array = (ulong_0 = ulong_1);
			dictionary_0 = dictionary_1;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException3(exception_, this, ulong_1, dictionary_1);
			throw;
		}
	}
}
