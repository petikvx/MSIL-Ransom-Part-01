using System.Drawing;
using System.IO;
using System.Reflection;
using SmartAssembly.StringsEncoding;

namespace ns0;

internal sealed class Class19
{
	public static Bitmap smethod_0(string string_0)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Strings.Get(2952) + string_0 + Strings.Get(3013));
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	public static Icon smethod_1(string string_0)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Strings.Get(2952) + string_0 + Strings.Get(3022));
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}
}
