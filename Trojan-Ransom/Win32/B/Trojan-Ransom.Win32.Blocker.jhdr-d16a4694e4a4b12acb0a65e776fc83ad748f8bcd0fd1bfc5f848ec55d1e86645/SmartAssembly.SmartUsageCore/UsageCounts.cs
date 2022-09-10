using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

public class UsageCounts
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 272)]
	private struct Struct27
	{
	}

	private readonly ulong[] ulong_0;

	private readonly Dictionary<string, ulong> dictionary_0;

	private static readonly object object_0;

	private static readonly Array array_0 = new char[136];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

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

	static UsageCounts()
	{
		byte[] publicKeyToken;
		int num = (publicKeyToken = Assembly.GetExecutingAssembly().GetName().GetPublicKeyToken()).Length;
		char[] array = new char[num];
		for (int i = 0; i < num; i++)
		{
			int num2 = i;
			int num3 = publicKeyToken[i] & 0xFF;
			array[num2] = (char)(num3 ^ (num3 << 3));
		}
		object_0 = array;
		object_1 = new string[6];
	}
}
