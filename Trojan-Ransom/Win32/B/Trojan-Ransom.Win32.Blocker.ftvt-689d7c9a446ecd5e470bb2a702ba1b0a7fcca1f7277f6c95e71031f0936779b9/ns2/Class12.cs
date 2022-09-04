using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns2;

internal sealed class Class12
{
	[NonSerialized]
	internal static GetString getString_0;

	static Class12()
	{
		Strings.CreateGetStringDelegate(typeof(Class12));
	}

	public static Bitmap smethod_0(string string_0)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(getString_0(2646) + string_0 + getString_0(2707));
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	public static Icon smethod_1(string string_0)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(getString_0(2646) + string_0 + getString_0(2716));
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}
}
