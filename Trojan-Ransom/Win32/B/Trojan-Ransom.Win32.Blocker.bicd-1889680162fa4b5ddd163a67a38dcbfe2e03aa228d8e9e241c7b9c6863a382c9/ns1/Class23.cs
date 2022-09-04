using System.Drawing;
using System.IO;
using System.Reflection;
using ns4;

namespace ns1;

internal sealed class Class23
{
	public static Bitmap smethod_0(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + string_0 + ".png");
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	public static Icon smethod_1(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + string_0 + ".ico");
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static Class23()
	{
		GClass11.smethod_0();
	}
}
