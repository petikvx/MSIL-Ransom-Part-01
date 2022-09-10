using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

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

	static UsageCounts()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static MethodInfo smethod_0(Type type_0, string string_0, Type[] type_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 52:
				return type_0.GetMethod(string_0, type_1);
			}
		}
	}

	internal static byte[] smethod_1(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 52:
				return Convert.FromBase64String(string_0);
			}
		}
	}

	internal static void smethod_2(Control control_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 38:
				control_0.set_TabIndex(int_0);
				return;
			case 39:
				control_0.set_Height(int_0);
				return;
			}
		}
	}

	internal static byte smethod_3(ref Color color_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 123:
				return color_0.B;
			}
		}
	}

	internal static DialogResult smethod_4(CommonDialog commonDialog_0, int int_0, int int_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 47:
				return commonDialog_0.ShowDialog();
			}
		}
	}

	internal static Assembly smethod_5(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 44:
				return Assembly.GetExecutingAssembly();
			}
		}
	}
}
