using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns10;

internal sealed class Class57
{
	[NonSerialized]
	internal static GetString getString_0;

	public static Bitmap smethod_0(string string_0)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(getString_0(107384512) + string_0 + getString_0(107388790));
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static Class57()
	{
		Strings.CreateGetStringDelegate(typeof(Class57));
	}
}
