using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class19
{
	public static Bitmap smethod_0(string string_0)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream stream = Class21.smethod_0(Class24.smethod_1(556, 535), "SmartAssembly.SmartExceptionsCore.Resources." + string_0 + ".png", 533, 590);
			return (stream == null) ? ((Bitmap)null) : new Bitmap(stream);
		}
		catch
		{
			return null;
		}
	}

	public static Icon smethod_1(string string_0)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream stream = Class21.smethod_0(Class24.smethod_1(256, 315), "SmartAssembly.SmartExceptionsCore.Resources." + string_0 + ".ico", 552, 627);
			return (stream == null) ? ((Icon)null) : new Icon(stream);
		}
		catch
		{
			return null;
		}
	}

	static Class19()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static Type smethod_2(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 16:
				return assembly_0.GetType(string_0);
			}
		}
	}

	internal static string smethod_3(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 35:
				return assembly_0.FullName;
			}
		}
	}

	internal static FieldInfo[] smethod_4(Type type_0, BindingFlags bindingFlags_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 38:
				return type_0.GetFields(bindingFlags_0);
			}
		}
	}
}
