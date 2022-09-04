using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace SmartAssembly.SmartUsageCore;

public class UsageCounts
{
	internal ulong[] ulong_0;

	internal Dictionary<string, ulong> dictionary_0;

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
			ulong[] array = (ulong_0 = staticFeatureCounts);
			Dictionary<string, ulong> dictionary = (dictionary_0 = dynamicFeatureCounts);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, staticFeatureCounts, dynamicFeatureCounts);
			throw;
		}
	}

	[SecuritySafeCritical]
	static UsageCounts()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static bool smethod_0(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 26:
				return string_0 == string_1;
			case 27:
				return string_0.StartsWith(string_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(TextBox textBox_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 50:
				textBox_0.set_Text(string_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_2(ref Size size_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 0:
				return size_0.Height;
			}
		}
	}
}
