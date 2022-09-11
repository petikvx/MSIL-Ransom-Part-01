using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns12;

namespace ns18;

internal static class Class110
{
	[NonSerialized]
	internal static GetString getString_0;

	public static Dictionary<string, object> smethod_0(object object_0)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (!object_0.GetType().IsConstructedGenericType)
		{
			throw new FormatException(Class122.InvalidConnectionData);
		}
		PropertyInfo[] properties = object_0.GetType().GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			object value = propertyInfo.GetValue(object_0, null);
			dictionary.Add(propertyInfo.Name, value);
		}
		return dictionary;
	}

	internal static Enum29 smethod_1()
	{
		if (Path.DirectorySeparatorChar == '/')
		{
			return Enum29.const_2;
		}
		if (Path.DirectorySeparatorChar == '\\')
		{
			return Enum29.const_1;
		}
		return Enum29.const_3;
	}

	internal static int smethod_2(string string_0, string string_1)
	{
		return string.Compare(string_0.Replace(getString_0(107409279), getString_0(107397833)), string_1.Replace(getString_0(107409279), getString_0(107397833)));
	}

	internal static int smethod_3(Guid guid_0, Guid guid_1)
	{
		return smethod_2(guid_0.ToString(), guid_1.ToString());
	}

	static Class110()
	{
		Strings.CreateGetStringDelegate(typeof(Class110));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398011), getString_0(107398006)).Replace(getString_0(107397969), getString_0(107397964)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397959)))
		{
			throw new SecurityException(getString_0(107397934));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
