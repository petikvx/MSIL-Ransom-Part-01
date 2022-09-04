using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class21
{
	public static Bitmap smethod_0(string string_0)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream stream = smethod_4(DoNotPruneAttribute.smethod_3(934, 1022), Class37.smethod_3("SmartAssembly.SmartExceptionsCore.Resources.", string_0, ".png", 584, 602), 803, 821);
			return (stream == null) ? ((Bitmap)null) : new Bitmap(stream);
		}
		catch
		{
			return null;
		}
	}

	public static Icon smethod_1(string string_0)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream stream = smethod_4(DoNotPruneAttribute.smethod_3(1006, 950), Class37.smethod_3("SmartAssembly.SmartExceptionsCore.Resources.", string_0, ".ico", 127, 109), 644, 658);
			return (stream == null) ? ((Icon)null) : new Icon(stream);
		}
		catch
		{
			return null;
		}
	}

	[SecuritySafeCritical]
	static Class21()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_2(Control control_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 57:
				control_0.set_TabIndex(int_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_3(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 66:
				return type_0.Assembly;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Stream smethod_4(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 22:
				return assembly_0.GetManifestResourceStream(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_5(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 116:
				return type_0.GetArrayRank();
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_6(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 73:
				return type_0.IsPrimitive;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_7(StackFrame stackFrame_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 65:
				return stackFrame_0.GetILOffset();
			}
		}
	}

	[SecuritySafeCritical]
	internal static FieldInfo[] smethod_8(Type type_0, BindingFlags bindingFlags_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 116:
				return type_0.GetFields(bindingFlags_0);
			}
		}
	}
}
