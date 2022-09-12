using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns4;

internal sealed class Class32
{
	[NonSerialized]
	internal static GetString getString_0;

	public static Bitmap smethod_0(string string_0)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(getString_0(107388158) + string_0 + getString_0(107388609));
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
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
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(getString_0(107388158) + string_0 + getString_0(107388600));
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static Class32()
	{
		Strings.CreateGetStringDelegate(typeof(Class32));
	}
}
